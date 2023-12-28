using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TextBox = System.Windows.Forms.TextBox;
using DataTable = System.Data.DataTable;
using System.Windows.Forms;
using System.Collections;

namespace LaptopManagement
{
    public partial class FrmLaptopManagement : Form
    {
        public FrmLaptopManagement()
        {
            InitializeComponent();
        }

        public List<Laptop> laptopList = new List<Laptop>();
        // loadData * 0 (chua co dữ lieu);
        // loadData * 1 (co dû lieu từ excel);
        // loadData = 2 (co dû lieu từ sql);
        public int loadData = 0;
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string ExcelFilePath = ProjectPath + "\\Data\\LaptopList.xlsx";
        string connectionString =
        "Data Source=BLUBIN\\BLUBIN;Initial Catalog=LaptopDB;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;Trusted_Connection=True";
        int CurrentLaptopIndex = -1;
        DataTable datatable;
        BindingSource binding = new BindingSource();


        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            loadData = 1;
            datatable = new DataTable();
            laptopList.Clear();

            int colCount = 9;
            int NumDataRow = ReadDataFromFile(laptopList, ExcelFilePath, colCount);

            var sublist = laptopList.Select(x => new
            {
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate.ToString("dd/MM/yyyy"),
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price.ToString() + " USD",
            }).ToList();

            datatable.Columns.Add("LaptopID");
            datatable.Columns.Add("LaptopName");
            datatable.Columns.Add("LaptopType");
            datatable.Columns.Add("ProductDate");
            datatable.Columns.Add("Processor");
            datatable.Columns.Add("HDD");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Price");
            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }
            dgwLaptopList.DataSource = datatable;
        }

        public int ReadDataFromFile(List<Laptop> DataList, string FilePath, int colCount)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            xlWorksheet.Columns.ClearFormats();
            xlWorksheet.Rows.ClearFormats();

            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            int numPhone = 0;

            string LaptopID = "";
            string LaptopName = "";
            string LaptopType = "";
            DateTime ProductDate = DateTime.Now;
            string Processor = "";
            string HDD = "";
            string RAM = "";
            int Price = 0;
            string imageName = "";


            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    switch (j)
                    {
                        case 1:
                            LaptopID = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 2:
                            LaptopName = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 3:
                            LaptopType = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 4:
                            ProductDate = DateTime.ParseExact(xlRange.Cells[i, j].Value2.ToString(), "dd/MM/yyyy", 
                                CultureInfo.InvariantCulture);
                            break;
                        case 5:
                            Processor = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 6:
                            HDD = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 7:
                            RAM = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 8:
                            Price = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
                        case 9:
                            imageName = xlRange.Cells[i, j].Value2.ToString(); break;
                    }
                }
                DataList.Add(new Laptop());
                DataList[numPhone].LaptopID = LaptopID;
                DataList[numPhone].LaptopName = LaptopName;
                DataList[numPhone].LaptopType = LaptopType;
                DataList[numPhone].ProductDate = ProductDate;
                DataList[numPhone].Processor = Processor;
                DataList[numPhone].HDD = HDD;
                DataList[numPhone].RAM = RAM;
                DataList[numPhone].Price = Price;
                DataList[numPhone].Imagename = imageName;
                numPhone = numPhone + 1;

            }
            xlApp.Quit();
            MessageBox.Show("Load Data From Excel Finished! : " + (rowCount - 1).ToString() + " Records");
            return (rowCount - 1); //Khong Tinh Dong Tieu De
        }
        private void dgwLaptopList_SelectionChanged(object sender, EventArgs e)
        {
            if (laptopList.Count == 0 || datatable.Rows.Count == 0) return;
            CurrentLaptopIndex = dgwLaptopList.CurrentRow.Index;
            if (CurrentLaptopIndex >= 0 && CurrentLaptopIndex < laptopList.Count)
                picLaptopImage.Image = Image.FromFile(ProjectPath + "\\Image\\" + laptopList[CurrentLaptopIndex].Imagename);
        }

        private void btnLoadSQL_Click(object sender, EventArgs e)
        {
            loadData = 2;
            datatable = new DataTable(); laptopList.Clear();
            int NumDataRow = ReadDataFromSQLServer(laptopList, connectionString);
            var sublist = laptopList.Select(x => new
            {
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate.ToString("dd/MM/yyyy"),
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price.ToString() + " USD",
            })
                .ToList();

            datatable.Columns.Add("LaptopID");
            datatable.Columns.Add("LaptopName");
            datatable.Columns.Add("LaptopType");
            datatable.Columns.Add("ProductDate");
            datatable.Columns.Add("Processor");
            datatable.Columns.Add("HDD");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Price");
            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }
            binding.AllowNew = true;
            binding.DataSource = datatable;
            dgwLaptopList.AutoGenerateColumns = false;
            dgwLaptopList.DataSource = binding;

        }

        public int ReadDataFromSQLServer(List<Laptop> DataList, string connectionString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            int iRow = 0;
            int NumRecords = 0;
            cnn.Open();
            try
            {
                Console.WriteLine("Connection Open I ");
                string SqlString = @"SELECT
                                LaptopID,
                                LaptopName,
                                LaptopType,
                                ProductDate = Convert(varchar(10), CONVERT(date, ProductDate, 106), 103),
                                Processor,
                                HDD,
                                RAM,
                                Price,
                                ImageName
                                FROM dbo.Laptop";

                using (var command = new SqlCommand(SqlString, cnn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            laptopList.Add(new Laptop());
                            laptopList[iRow].LaptopID = reader.GetString(0);
                            laptopList[iRow].LaptopName = reader.GetString(1);
                            laptopList[iRow].LaptopType = reader.GetString(2);
                            laptopList[iRow].ProductDate = DateTime.ParseExact(reader.GetString(3), 
                                "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            laptopList[iRow].Processor = reader.GetString(4);
                            laptopList[iRow].HDD = reader.GetString(5);
                            laptopList[iRow].RAM = reader.GetString(6);
                            laptopList[iRow].Price = reader.GetInt32(7);
                            laptopList[iRow].Imagename = reader.GetString(8);
                            iRow = iRow + 1;
                        }
                    }
                }
                SqlCommand cmd = new SqlCommand("select count(*) from Laptop", cnn);
                object result = cmd.ExecuteScalar();
                NumRecords = int.Parse(result.ToString());
                MessageBox.Show("Finish Load Data From SQL: " + NumRecords.ToString() + "Records");
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can not open connection I : " + ex.Message);
            }
            return NumRecords;
        }

        private void dgwLaptopList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnPrice_KeyPress);
            if (dgwLaptopList.CurrentCell.ColumnIndex == 8)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnPrice_KeyPress);
                }
            }
        }

        private void ColumnPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();
            laptop.LaptopID = "LT008";
            laptop.LaptopName = "Macbook air M1";
            laptop.LaptopType = "Macbook";
            laptop.ProductDate = DateTime.ParseExact("01 / 01 / 1900", "dd / MM / yyyy", CultureInfo.InvariantCulture);
            laptop.Processor = "";
            laptop.HDD = "512GB";
            laptop.RAM = "16GB";
            laptop.Price = 1200;
            laptop.Imagename = "Laptop.jpg";
            laptopList.Add(laptop);
            DataRow newrow;
            newrow = datatable.NewRow();
            newrow["LaptopID"] = laptop.LaptopID;
            newrow["LaptopName"] = laptop.LaptopName;
            newrow["LaptopType"] = laptop.LaptopType;
            newrow["ProductDate"] = laptop.ProductDate.ToString("dd / MM / yyyy");
            newrow["Processor"] = laptop.Processor;
            newrow["HDD"] = laptop.HDD;
            newrow["RAM"] = laptop.RAM;
            newrow["Price"] = laptop.Price.ToString() + " USD";
            datatable.Rows.Add(newrow);
            datatable.AcceptChanges();
            MessageBox.Show("Finish Adding");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Math.Min(datatable.Rows.Count, laptopList.Count); i++)
            {
                DataRow row = datatable.Rows[i];

                laptopList[i].LaptopID = row["LaptopID"].ToString();
                laptopList[i].LaptopName = row["LaptopName"].ToString();
                laptopList[i].LaptopType = row["LaptopType"].ToString();
                laptopList[i].ProductDate = DateTime.ParseExact(row["ProductDate"].ToString(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
                laptopList[i].Processor = row["Processor"].ToString();
                laptopList[i].HDD = row["HDD"].ToString();
                laptopList[i].RAM = row["RAM"].ToString();

                string sPrice = row["Price"].ToString();
                int spaceIndex = sPrice.IndexOf(" ");

                if (spaceIndex != -1)
                {
                    laptopList[i].Price = Convert.ToInt32(sPrice.Substring(0, spaceIndex));
                }
                else
                {
                    MessageBox.Show("Invalid Price Format");
                    laptopList[i].Price = 0; 
                }
            }

            MessageBox.Show("Finish Update");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Laptop lap;
            if (CurrentLaptopIndex >= 0)
                lap = laptopList[CurrentLaptopIndex];
            else
                return;
            string question = "Do You Want to delete Laptop:" + lap.LaptopID;
            DialogResult result = MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                laptopList.RemoveAt(CurrentLaptopIndex);
                binding.RemoveAt(CurrentLaptopIndex);
                MessageBox.Show("Finish Delete");
            }
        }

        private void btnUpdateSource_Click(object sender, EventArgs e)
        {
            if (loadData == 1)
                WriteDataToExcelFile(laptopList, ExcelFilePath);
            else
                WriteDataToSQLServer(laptopList, connectionString);
        }
        
        public void WriteDataToExcelFile(List<Laptop> SPList, string ExcelFilePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange;
            string[,] Data = new string[1, 9];
            int idxRow = 2;
            foreach (Laptop sp in SPList)
            {
                Data[0, 0] = sp.LaptopID;
                Data[0, 1] = sp.LaptopName;
                Data[0, 2] = sp.LaptopType;
                Data[0, 3] = sp.ProductDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                Data[0, 4] = sp.Processor;
                Data[0, 5] = sp.HDD;
                Data[0, 6] = sp.RAM;
                Data[0, 7] = sp.Price.ToString();
                Data[0, 8] = sp.Imagename;
                xlRange = xlWorksheet.get_Range("A" + idxRow.ToString(), "3" + idxRow.ToString());
                xlRange.Value2 = Data;
                idxRow = idxRow + 1;
                xlWorkbook.Save();
                xlWorkbook.Close(); xlApp.Quit();
                MessageBox.Show("Finish Update to Datasource Excel");

            }
        }

        public void WriteDataToSQLServer(List<Laptop> SPList, string connetionString)
        { 
            SqlConnection cnn;
            SqlCommand myCommand = new SqlCommand();
            string query;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open! ");
                query = "TRUNCATE TABLE Laptop";
                myCommand.CommandText = query;
                myCommand.Connection = cnn;
                myCommand.ExecuteNonQuery();
                query = @"INSERT INTO Laptop(LaptopID,LaptopName,LaptopType,
                        ProductDate,Processor,HDD,RAM,Price,ImageName) ";
                query += @"VALUES (@LaptopID, @LaptopName, @LaptopType, @ProductDate,
                        @Processor, @HDD, @RAM, @Price, @ImageName)";


                myCommand.CommandText = query;
                myCommand.Connection = cnn;
                myCommand.Parameters.Add(new SqlParameter("@LaptopID", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@LaptopName", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@LaptopType", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@ProductDate", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@Processor", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@HDD", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@RAM", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@ImageName", SqlDbType.NVarChar));
                foreach (Laptop sp in SPList)
                {
                    myCommand.Parameters[0].Value = sp.LaptopID;
                    myCommand.Parameters[1].Value = sp.LaptopName;
                    myCommand.Parameters[2].Value = sp.LaptopType;
                    myCommand.Parameters[3].Value = sp.ProductDate.ToString("yyyy - MM - dd", CultureInfo.InvariantCulture);
                    myCommand.Parameters[4].Value = sp.Processor;
                    myCommand.Parameters[5].Value = sp.HDD;
                    myCommand.Parameters[6].Value = sp.RAM;
                    myCommand.Parameters[7].Value = sp.Price;
                    myCommand.Parameters[8].Value = sp.Imagename;
                    myCommand.ExecuteNonQuery();
                    cnn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can not open connection! " + ex.Message);
            }	
            MessageBox.Show("Finish Update to Datasource SQL Server");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Login loginForm = new Login();  
            loginForm.Show();
        }
    }
    
}

