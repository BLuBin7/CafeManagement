using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
{
    public partial class Dashboard : Form
    {
        private User loggedInUser;

        public Dashboard()
        {
            loggedInUser = Login.OriginalForm.currentUser;
            InitializeComponent();
            lblUsername.Text = $"Welcome, {loggedInUser.UserName}!";
        }


        public List<Laptop> laptopList = new List<Laptop>();
        public int loadData = 0;
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string connectionString =
        "Data Source=BLUBIN\\BLUBIN;Initial Catalog=LaptopDB;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;Trusted_Connection=True";
        int CurrentLaptopIndex = -1;
        DataTable datatable;
        BindingSource binding = new BindingSource();


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
                            laptopList[iRow].ProductDate = DateTime.ParseExact(reader.GetString(3), "dd/MM/yyyy", 
                                                            CultureInfo.InvariantCulture);
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
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can not open connection I : " + ex.Message);
            }
            return NumRecords;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDataFromSQLServer();
        }

        private void LoadDataFromSQLServer()
        {
            laptopList.Clear();

            int numRecords = ReadDataFromSQLServer(laptopList, connectionString);

            binding.DataSource = laptopList;
            dgwLaptopList.DataSource = binding;

        }

        private void dgwLaptopList_SelectionChanged(object sender, EventArgs e)
        {

            if (dgwLaptopList.CurrentRow != null)
            {

                CurrentLaptopIndex = dgwLaptopList.CurrentRow.Index;
                if (CurrentLaptopIndex >= 0 && CurrentLaptopIndex < laptopList.Count)
                {
                    string imagePath = Path.Combine(ProjectPath, "Image", laptopList[CurrentLaptopIndex].Imagename);

                    if (File.Exists(imagePath))
                    {
                        picLaptopImage.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        picLaptopImage.Image = null;
                        MessageBox.Show("Image file not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (CurrentLaptopIndex >= 0 && CurrentLaptopIndex < laptopList.Count)
            {
                string selectedLaptopID = laptopList[CurrentLaptopIndex].LaptopID;

                AddToCart(loggedInUser.UserName, selectedLaptopID);

                MessageBox.Show("Laptop added to your cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a laptop to add to your cart.", "Selection Required", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
        }


        private void AddToCart(string customerID, string laptopID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into the Cart table
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Cart (UserName, LaptopID) VALUES (@UserName, @LaptopID)", connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", customerID);
                    cmd.Parameters.AddWithValue("@LaptopID", laptopID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btngotoCart_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart();
            this.Hide();

            cartForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
