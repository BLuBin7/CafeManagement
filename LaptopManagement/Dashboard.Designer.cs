using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.LinkLabel;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LaptopManagement
{
    partial class Dashboard: Form
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwLaptopList = new System.Windows.Forms.DataGridView();
            this.colLaptopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaptopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaptopType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLaptopImage = new System.Windows.Forms.PictureBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btngotoCart = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaptopList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaptopImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLaptopList
            // 
            this.dgwLaptopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLaptopList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLaptopID,
            this.colLaptopName,
            this.colLaptopType,
            this.colProductDate});
            this.dgwLaptopList.Location = new System.Drawing.Point(12, 57);
            this.dgwLaptopList.MultiSelect = false;
            this.dgwLaptopList.Name = "dgwLaptopList";
            this.dgwLaptopList.RowHeadersWidth = 43;
            this.dgwLaptopList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwLaptopList.Size = new System.Drawing.Size(1134, 326);
            this.dgwLaptopList.TabIndex = 0;
            this.dgwLaptopList.SelectionChanged += new System.EventHandler(this.dgwLaptopList_SelectionChanged);
            // 
            // colLaptopID
            // 
            this.colLaptopID.DataPropertyName = "LaptopID";
            this.colLaptopID.HeaderText = "LaptopID";
            this.colLaptopID.MinimumWidth = 6;
            this.colLaptopID.Name = "colLaptopID";
            this.colLaptopID.Width = 150;
            // 
            // colLaptopName
            // 
            this.colLaptopName.DataPropertyName = "LaptopName";
            this.colLaptopName.HeaderText = "LaptopName";
            this.colLaptopName.MinimumWidth = 6;
            this.colLaptopName.Name = "colLaptopName";
            this.colLaptopName.Width = 150;
            // 
            // colLaptopType
            // 
            this.colLaptopType.DataPropertyName = "LaptopType";
            this.colLaptopType.HeaderText = "LaptopType";
            this.colLaptopType.MinimumWidth = 6;
            this.colLaptopType.Name = "colLaptopType";
            this.colLaptopType.Width = 150;
            // 
            // colProductDate
            // 
            this.colProductDate.DataPropertyName = "ProductDate";
            this.colProductDate.HeaderText = "ProductDate";
            this.colProductDate.MinimumWidth = 6;
            this.colProductDate.Name = "colProductDate";
            this.colProductDate.Width = 150;
            // 
            // picLaptopImage
            // 
            this.picLaptopImage.ErrorImage = null;
            this.picLaptopImage.InitialImage = null;
            this.picLaptopImage.Location = new System.Drawing.Point(1152, 112);
            this.picLaptopImage.Name = "picLaptopImage";
            this.picLaptopImage.Size = new System.Drawing.Size(248, 271);
            this.picLaptopImage.TabIndex = 1;
            this.picLaptopImage.TabStop = false;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.Location = new System.Drawing.Point(53, 409);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(147, 49);
            this.btnAddtoCart.TabIndex = 3;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1219, 414);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 44);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btngotoCart
            // 
            this.btngotoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngotoCart.Location = new System.Drawing.Point(940, 414);
            this.btngotoCart.Name = "btngotoCart";
            this.btngotoCart.Size = new System.Drawing.Size(185, 47);
            this.btngotoCart.TabIndex = 10;
            this.btngotoCart.Text = "Cart";
            this.btngotoCart.UseVisualStyleBackColor = true;
            this.btngotoCart.Click += new System.EventHandler(this.btngotoCart_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(478, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 36);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "label1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 490);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btngotoCart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.picLaptopImage);
            this.Controls.Add(this.dgwLaptopList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaptopList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaptopImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLaptopList;
        private System.Windows.Forms.PictureBox picLaptopImage;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btngotoCart;
        private System.Windows.Forms.Label lblUsername;
        private DataGridViewTextBoxColumn colLaptopID;
        private DataGridViewTextBoxColumn colLaptopName;
        private DataGridViewTextBoxColumn colLaptopType;
        private DataGridViewTextBoxColumn colProductDate;
    }
}

