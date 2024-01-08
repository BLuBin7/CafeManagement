using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class CaFeManagement : Form
    {
        public CaFeManagement()
        {
            InitializeComponent();
        }

        CafeDBDataContext db = new CafeDBDataContext();

        private void cafeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDBDataSet.Cafe' table. You can move, or remove it, as needed.
            this.cafeTableAdapter.Fill(this.cafeDBDataSet.Cafe);
            cafeBindingSource.DataSource = this.cafeDBDataSet;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDBDataSet.Cafe' table. You can move, or remove it, as needed.
            this.cafeTableAdapter.Fill(this.cafeDBDataSet.Cafe);

        }

        private void cafeBindingNavigator1SaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDBDataSet);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cafeBindingSource.EndEdit();
            db.SubmitChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cafeBindingSource.EndEdit();
            db.SubmitChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cafeBindingSource.RemoveCurrent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
