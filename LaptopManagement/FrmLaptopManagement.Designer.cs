using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.LinkLabel;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LaptopManagement
{
    partial class FrmLaptopManagement : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaptopManagement));
            this.dgwLaptopList = new System.Windows.Forms.DataGridView();
            this.colLaptopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaptopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaptopType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLaptopImage = new System.Windows.Forms.PictureBox();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateSource = new System.Windows.Forms.Button();
            this.btnLoadSQL = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.dgwLaptopList.Location = new System.Drawing.Point(30, 53);
            this.dgwLaptopList.MultiSelect = false;
            this.dgwLaptopList.Name = "dgwLaptopList";
            this.dgwLaptopList.RowHeadersWidth = 46;
            this.dgwLaptopList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwLaptopList.Size = new System.Drawing.Size(648, 328);
            this.dgwLaptopList.TabIndex = 0;
            this.dgwLaptopList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgwLaptopList_EditingControlShowing);
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
            this.picLaptopImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLaptopImage.ErrorImage")));
            this.picLaptopImage.Image = ((System.Drawing.Image)(resources.GetObject("picLaptopImage.Image")));
            this.picLaptopImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLaptopImage.InitialImage")));
            this.picLaptopImage.Location = new System.Drawing.Point(694, 119);
            this.picLaptopImage.Name = "picLaptopImage";
            this.picLaptopImage.Size = new System.Drawing.Size(279, 262);
            this.picLaptopImage.TabIndex = 1;
            this.picLaptopImage.TabStop = false;
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcel.Location = new System.Drawing.Point(30, 12);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(261, 35);
            this.btnLoadExcel.TabIndex = 2;
            this.btnLoadExcel.Text = "Load Data From Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(162, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(308, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateSource
            // 
            this.btnUpdateSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSource.Location = new System.Drawing.Point(470, 400);
            this.btnUpdateSource.Name = "btnUpdateSource";
            this.btnUpdateSource.Size = new System.Drawing.Size(273, 39);
            this.btnUpdateSource.TabIndex = 6;
            this.btnUpdateSource.Text = "Update to DataSource";
            this.btnUpdateSource.UseVisualStyleBackColor = true;
            this.btnUpdateSource.Click += new System.EventHandler(this.btnUpdateSource_Click);
            // 
            // btnLoadSQL
            // 
            this.btnLoadSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSQL.Location = new System.Drawing.Point(403, 12);
            this.btnLoadSQL.Name = "btnLoadSQL";
            this.btnLoadSQL.Size = new System.Drawing.Size(243, 35);
            this.btnLoadSQL.TabIndex = 7;
            this.btnLoadSQL.Text = "Load Data From SQL";
            this.btnLoadSQL.UseVisualStyleBackColor = true;
            this.btnLoadSQL.Click += new System.EventHandler(this.btnLoadSQL_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(862, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmLaptopManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 456);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadSQL);
            this.Controls.Add(this.btnUpdateSource);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadExcel);
            this.Controls.Add(this.picLaptopImage);
            this.Controls.Add(this.dgwLaptopList);
            this.Name = "FrmLaptopManagement";
            this.Text = "FrmLaptopManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLaptopList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaptopImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLaptopList;
        private System.Windows.Forms.PictureBox picLaptopImage;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateSource;
        private System.Windows.Forms.Button btnLoadSQL;
        private DataGridViewTextBoxColumn colLaptopID;
        private DataGridViewTextBoxColumn colLaptopName;
        private DataGridViewTextBoxColumn colLaptopType;
        private DataGridViewTextBoxColumn colProductDate;
        private System.Windows.Forms.Button btnExit;
    }
}

