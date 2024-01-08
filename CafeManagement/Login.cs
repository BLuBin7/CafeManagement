using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Login : Form
    {
        public bool IsAdmin { get; private set; }

        public static Login OriginalForm;
        public User currentUser;
        public string startupPath;
        public bool ResetLogin;
        public Login()
        {
            InitializeComponent();

            OriginalForm = this;
            startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            ResetLogin = true;
        }

        string connectionString =
       "Data Source=BLUBIN\\BLUBIN;Initial Catalog=CafeDB;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;Trusted_Connection=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                IsAdmin = true;
                DialogResult = DialogResult.OK;
                Close(); 
                return;
            }

            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            User user = ValidateUserCredentials(txtUserName.Text, txtPassword.Text);
            currentUser = user;
            if (user == null)   
            {
                MessageBox.Show("Username and Password are not matched. \n Please reinput or register a new one",
                                "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
                return;
            }
            IsAdmin = false;
            Dashboard dashboardForm = new Dashboard();
            DialogResult = DialogResult.OK;
            Close();
        }

        private User ValidateUserCredentials(string username, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check the user's credentials in the UserTable
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE UserName = @UserName AND Password = @Password", 
                                                    connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                UserName = reader["UserName"].ToString(),
                                Password = reader["Password"].ToString(),
                                CustomerID = reader["CustomerID"].ToString()
                            };

                            return user;
                        }
                    }
                }
            }

            return null; 
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void LinkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (IsAdmin==false)
            {
                RegistrationForm registrationForm = new RegistrationForm();
                this.Hide();
                registrationForm.ShowDialog();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if(ResetLogin ==  true)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }

    }
}
