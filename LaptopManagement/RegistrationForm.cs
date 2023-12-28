using LaptopManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAccountApp
{
    public partial class RegistrationForm : Form
    {
        string startupPath;
        Login ParentForm;
        public RegistrationForm()
        {
            InitializeComponent();
            startupPath = Login.OriginalForm.startupPath;
            ParentForm = Login.OriginalForm;
        }

        string connectionString =
          "Data Source=BLUBIN\\BLUBIN;Initial Catalog=LaptopDB;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;Trusted_Connection=True";


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (txtUserID.Text.Trim().Length == 0 || txtPassWord.Text.Trim().Length == 0 || txtCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("CustomerID, UserName, Password are not blank", "Input Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPassWord.Text != txtPassWordConfirm.Text)
            {
                MessageBox.Show("Password and Confirm Password are not matched", "Input Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Check if UserID exists in the database
            if (IsUserIDExists(txtUserID.Text))
            {
                MessageBox.Show("UserID is already existed", "Input Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Create User object
            User obj = new User
            {
                UserName = txtUserID.Text,
                Password = txtPassWord.Text,
                CustomerID = txtCustomerID.Text
            };

            // Create Customer object
            Customer objCustomer = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CustomerName = txtCustomerName.Text,
                Birthday = dtBirthDay.Value,
                Sex = (rdMale.Checked == true) ? Sex.Male : Sex.Female
            };

            // Save User and Customer to the database
            SaveToDatabase(obj, objCustomer);

            MessageBox.Show("New UserID is Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to check if UserID exists in the database
        private bool IsUserIDExists(string userName)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE UserName = @UserName", connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }


        private void SaveToDatabase(User user, Customer customer)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into CustomerTable with Avatar
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer (CustomerID, CustomerName, Birthday, Sex) " +
                    "VALUES (@CustomerID, @CustomerName, @Birthday, @Sex)", connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                    cmd.Parameters.AddWithValue("@Birthday", customer.Birthday);
                    cmd.Parameters.AddWithValue("@Sex", customer.Sex.ToString());

                    cmd.ExecuteNonQuery();
                }
               

                // Insert a new user with the default RoleID
                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO [User] (UserName, Password, CustomerID, RoleID) " +
                    "VALUES (@UserName, @Password, @CustomerID, @RoleID)", connection))
                {
                    cmdInsert.Parameters.AddWithValue("@UserName", user.UserName);
                    cmdInsert.Parameters.AddWithValue("@Password", user.Password);
                    cmdInsert.Parameters.AddWithValue("@CustomerID", user.CustomerID);
                    cmdInsert.Parameters.AddWithValue("@RoleID", 2);
                    cmdInsert.ExecuteNonQuery();
                }

            }   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = " ";
            txtCustomerName.Text = " ";
            txtPassWord.Text = " "; 
            txtPassWordConfirm.Text = " ";
            txtUserID.Text = " ";
            dtBirthDay.Value = DateTime.Now;

        }
    }
}
