using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.LinkLabel;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CafeManagement
{
    partial class Dashboard : Form
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cafeDBDataSet = new CafeManagement.CafeDBDataSet();
            this.cafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeTableAdapter = new CafeManagement.CafeDBDataSetTableAdapters.CafeTableAdapter();
            this.tableAdapterManager = new CafeManagement.CafeDBDataSetTableAdapters.TableAdapterManager();
            this.cafeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(517, 392);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 33);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(253, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 36);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "label1";
            // 
            // cafeDBDataSet
            // 
            this.cafeDBDataSet.DataSetName = "CafeDBDataSet";
            this.cafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeBindingSource
            // 
            this.cafeBindingSource.DataMember = "Cafe";
            this.cafeBindingSource.DataSource = this.cafeDBDataSet;
            // 
            // cafeTableAdapter
            // 
            this.cafeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CafeTableAdapter = this.cafeTableAdapter;
            this.tableAdapterManager.UpdateOrder = CafeManagement.CafeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cafeDataGridView
            // 
            this.cafeDataGridView.AutoGenerateColumns = false;
            this.cafeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cafeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cafeDataGridView.DataSource = this.cafeBindingSource;
            this.cafeDataGridView.Location = new System.Drawing.Point(22, 48);
            this.cafeDataGridView.Name = "cafeDataGridView";
            this.cafeDataGridView.RowHeadersWidth = 46;
            this.cafeDataGridView.Size = new System.Drawing.Size(601, 312);
            this.cafeDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CafeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CafeID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 112;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CafeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CafeName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CafeType";
            this.dataGridViewTextBoxColumn3.HeaderText = "CafeType";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OpeningDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OpeningDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 112;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PriceRange";
            this.dataGridViewTextBoxColumn5.HeaderText = "PriceRange";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 112;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 437);
            this.Controls.Add(this.cafeDataGridView);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
        private CafeDBDataSet cafeDBDataSet;
        private BindingSource cafeBindingSource;
        private CafeDBDataSetTableAdapters.CafeTableAdapter cafeTableAdapter;
        private CafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView cafeDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

