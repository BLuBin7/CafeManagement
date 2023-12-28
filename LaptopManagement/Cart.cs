using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
{
    public partial class Cart : Form
    {
        private User loggedInUser;
        public Cart()
        {
            loggedInUser = Login.OriginalForm.currentUser;
            InitializeComponent();
        }

        string connectionString =
       "Data Source=BLUBIN\\BLUBIN;Initial Catalog=LaptopDB;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;Trusted_Connection=True";

        private void Cart_Load(object sender, EventArgs e)
        {
            dgwCart.AutoGenerateColumns = true;

            dgwCart.Columns.Add("LaptopName", "Laptop Name");
            dgwCart.Columns.Add("LaptopType", "LaptopType");
            dgwCart.Columns.Add("Processor", "Processor");
            dgwCart.Columns.Add("HDD", "HDD");
            dgwCart.Columns.Add("RAM", "RAM");
            dgwCart.Columns.Add("Price", "Price");



            LoadCartItems(loggedInUser.UserName);
        }

        private void LoadCartItems(string userName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Select all laptop information for the logged-in user
                using (SqlCommand cmd = new SqlCommand("SELECT l.LaptopName, l.LaptopType,l.Processor, l.HDD, l.RAM,l.Price " +
                    "FROM Cart c JOIN Laptop l ON c.LaptopID = l.LaptopID WHERE c.UserName = @UserName", connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Add each cart item to the DataGridView
                            dgwCart.Rows.Add(reader["LaptopName"],
                                reader["LaptopType"],
                                reader["Processor"],
                                reader["HDD"],
                                reader["RAM"],
                                reader["Price"]
                                );
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
