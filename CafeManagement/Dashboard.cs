using CafeManagementLINQ;
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

namespace CafeManagement
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


        public List<Cafe> CafeList = new List<Cafe>();
        public int loadData = 0;
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string connectionString =
        "Data Source=BLUBIN\\BLUBIN;Initial Catalog=CafeDB;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;Trusted_Connection=True";
        int CurrentCafeIndex = -1;
        DataTable datatable;
        BindingSource binding = new BindingSource();


        private void dgwCafeList_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (CurrentCafeIndex >= 0 && CurrentCafeIndex < CafeList.Count)
            {
                string selectedCafeID = CafeList[CurrentCafeIndex].CafeID;

                AddToCart(loggedInUser.UserName, selectedCafeID);

                MessageBox.Show("Cafe added to your cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a Cafe to add to your cart.", "Selection Required", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
        }


        private void AddToCart(string customerID, string CafeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into the Cart table
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Cart (UserName, CafeID) VALUES (@UserName, @CafeID)", connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", customerID);
                    cmd.Parameters.AddWithValue("@CafeID", CafeID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDBDataSet.Cafe' table. You can move, or remove it, as needed.
            this.cafeTableAdapter.Fill(this.cafeDBDataSet.Cafe);

        }
    }
}
