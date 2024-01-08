namespace CafeManagement
{
    partial class CaFeManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.Label cafeIDLabel;
            System.Windows.Forms.Label cafeNameLabel;
            System.Windows.Forms.Label cafeTypeLabel;
            System.Windows.Forms.Label openingDateLabel;
            System.Windows.Forms.Label priceRangeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaFeManagement));
            this.cafeDBDataSet = new CafeManagement.CafeDBDataSet();
            this.cafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeTableAdapter = new CafeManagement.CafeDBDataSetTableAdapters.CafeTableAdapter();
            this.tableAdapterManager = new CafeManagement.CafeDBDataSetTableAdapters.TableAdapterManager();
            this.cafeBindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cafeBindingNavigator1SaveItem = new System.Windows.Forms.ToolStripButton();
            this.cafeDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cafeIDTextBox1 = new System.Windows.Forms.TextBox();
            this.cafeNameTextBox1 = new System.Windows.Forms.TextBox();
            this.cafeTypeTextBox1 = new System.Windows.Forms.TextBox();
            this.openingDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.priceRangeTextBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            cafeIDLabel = new System.Windows.Forms.Label();
            cafeNameLabel = new System.Windows.Forms.Label();
            cafeTypeLabel = new System.Windows.Forms.Label();
            openingDateLabel = new System.Windows.Forms.Label();
            priceRangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingNavigator1)).BeginInit();
            this.cafeBindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cafeIDLabel
            // 
            cafeIDLabel.AutoSize = true;
            cafeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cafeIDLabel.Location = new System.Drawing.Point(12, 334);
            cafeIDLabel.Name = "cafeIDLabel";
            cafeIDLabel.Size = new System.Drawing.Size(58, 17);
            cafeIDLabel.TabIndex = 2;
            cafeIDLabel.Text = "Cafe ID:";
            // 
            // cafeNameLabel
            // 
            cafeNameLabel.AutoSize = true;
            cafeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cafeNameLabel.Location = new System.Drawing.Point(12, 360);
            cafeNameLabel.Name = "cafeNameLabel";
            cafeNameLabel.Size = new System.Drawing.Size(82, 17);
            cafeNameLabel.TabIndex = 4;
            cafeNameLabel.Text = "Cafe Name:";
            // 
            // cafeTypeLabel
            // 
            cafeTypeLabel.AutoSize = true;
            cafeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cafeTypeLabel.Location = new System.Drawing.Point(12, 386);
            cafeTypeLabel.Name = "cafeTypeLabel";
            cafeTypeLabel.Size = new System.Drawing.Size(77, 17);
            cafeTypeLabel.TabIndex = 6;
            cafeTypeLabel.Text = "Cafe Type:";
            // 
            // openingDateLabel
            // 
            openingDateLabel.AutoSize = true;
            openingDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            openingDateLabel.Location = new System.Drawing.Point(12, 413);
            openingDateLabel.Name = "openingDateLabel";
            openingDateLabel.Size = new System.Drawing.Size(100, 17);
            openingDateLabel.TabIndex = 8;
            openingDateLabel.Text = "Opening Date:";
            // 
            // priceRangeLabel
            // 
            priceRangeLabel.AutoSize = true;
            priceRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceRangeLabel.Location = new System.Drawing.Point(12, 438);
            priceRangeLabel.Name = "priceRangeLabel";
            priceRangeLabel.Size = new System.Drawing.Size(90, 17);
            priceRangeLabel.TabIndex = 10;
            priceRangeLabel.Text = "Price Range:";
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
            // cafeBindingNavigator1
            // 
            this.cafeBindingNavigator1.AddNewItem = this.toolStripButton5;
            this.cafeBindingNavigator1.BindingSource = this.cafeBindingSource;
            this.cafeBindingNavigator1.CountItem = this.toolStripLabel1;
            this.cafeBindingNavigator1.DeleteItem = this.toolStripButton6;
            this.cafeBindingNavigator1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cafeBindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.cafeBindingNavigator1SaveItem});
            this.cafeBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.cafeBindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.cafeBindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.cafeBindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.cafeBindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.cafeBindingNavigator1.Name = "cafeBindingNavigator1";
            this.cafeBindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.cafeBindingNavigator1.Size = new System.Drawing.Size(625, 26);
            this.cafeBindingNavigator1.TabIndex = 0;
            this.cafeBindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(26, 23);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 23);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(26, 23);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(26, 23);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(26, 23);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.333333F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 26);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(26, 23);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(26, 23);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // cafeBindingNavigator1SaveItem
            // 
            this.cafeBindingNavigator1SaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cafeBindingNavigator1SaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cafeBindingNavigator1SaveItem.Image")));
            this.cafeBindingNavigator1SaveItem.Name = "cafeBindingNavigator1SaveItem";
            this.cafeBindingNavigator1SaveItem.Size = new System.Drawing.Size(26, 23);
            this.cafeBindingNavigator1SaveItem.Text = "Save Data";
            this.cafeBindingNavigator1SaveItem.Click += new System.EventHandler(this.cafeBindingNavigator1SaveItem_Click);
            // 
            // cafeDataGridView1
            // 
            this.cafeDataGridView1.AutoGenerateColumns = false;
            this.cafeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cafeDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.cafeDataGridView1.DataSource = this.cafeBindingSource;
            this.cafeDataGridView1.Location = new System.Drawing.Point(12, 29);
            this.cafeDataGridView1.Name = "cafeDataGridView1";
            this.cafeDataGridView1.RowHeadersWidth = 46;
            this.cafeDataGridView1.Size = new System.Drawing.Size(597, 285);
            this.cafeDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CafeID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CafeID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 112;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CafeName";
            this.dataGridViewTextBoxColumn7.HeaderText = "CafeName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 112;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CafeType";
            this.dataGridViewTextBoxColumn8.HeaderText = "CafeType";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 112;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OpeningDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "OpeningDate";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 112;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PriceRange";
            this.dataGridViewTextBoxColumn10.HeaderText = "PriceRange";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 112;
            // 
            // cafeIDTextBox1
            // 
            this.cafeIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "CafeID", true));
            this.cafeIDTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeIDTextBox1.Location = new System.Drawing.Point(116, 334);
            this.cafeIDTextBox1.Name = "cafeIDTextBox1";
            this.cafeIDTextBox1.Size = new System.Drawing.Size(200, 23);
            this.cafeIDTextBox1.TabIndex = 3;
            // 
            // cafeNameTextBox1
            // 
            this.cafeNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "CafeName", true));
            this.cafeNameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeNameTextBox1.Location = new System.Drawing.Point(116, 360);
            this.cafeNameTextBox1.Name = "cafeNameTextBox1";
            this.cafeNameTextBox1.Size = new System.Drawing.Size(200, 23);
            this.cafeNameTextBox1.TabIndex = 5;
            // 
            // cafeTypeTextBox1
            // 
            this.cafeTypeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "CafeType", true));
            this.cafeTypeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeTypeTextBox1.Location = new System.Drawing.Point(116, 386);
            this.cafeTypeTextBox1.Name = "cafeTypeTextBox1";
            this.cafeTypeTextBox1.Size = new System.Drawing.Size(200, 23);
            this.cafeTypeTextBox1.TabIndex = 7;
            // 
            // openingDateDateTimePicker1
            // 
            this.openingDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cafeBindingSource, "OpeningDate", true));
            this.openingDateDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingDateDateTimePicker1.Location = new System.Drawing.Point(116, 412);
            this.openingDateDateTimePicker1.Name = "openingDateDateTimePicker1";
            this.openingDateDateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.openingDateDateTimePicker1.TabIndex = 9;
            // 
            // priceRangeTextBox1
            // 
            this.priceRangeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "PriceRange", true));
            this.priceRangeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRangeTextBox1.Location = new System.Drawing.Point(116, 438);
            this.priceRangeTextBox1.Name = "priceRangeTextBox1";
            this.priceRangeTextBox1.Size = new System.Drawing.Size(200, 23);
            this.priceRangeTextBox1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(366, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(434, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 32);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(498, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(532, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 32);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CaFeManagement
            // 
            this.ClientSize = new System.Drawing.Size(625, 494);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(cafeIDLabel);
            this.Controls.Add(this.cafeIDTextBox1);
            this.Controls.Add(cafeNameLabel);
            this.Controls.Add(this.cafeNameTextBox1);
            this.Controls.Add(cafeTypeLabel);
            this.Controls.Add(this.cafeTypeTextBox1);
            this.Controls.Add(openingDateLabel);
            this.Controls.Add(this.openingDateDateTimePicker1);
            this.Controls.Add(priceRangeLabel);
            this.Controls.Add(this.priceRangeTextBox1);
            this.Controls.Add(this.cafeDataGridView1);
            this.Controls.Add(this.cafeBindingNavigator1);
            this.Name = "CaFeManagement";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingNavigator1)).EndInit();
            this.cafeBindingNavigator1.ResumeLayout(false);
            this.cafeBindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator cafeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cafeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cafeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox cafeIDTextBox;
        private System.Windows.Forms.TextBox cafeNameTextBox;
        private System.Windows.Forms.TextBox cafeTypeTextBox;
        private System.Windows.Forms.DateTimePicker openingDateDateTimePicker;
        private System.Windows.Forms.TextBox priceRangeTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLogout;
        private CafeManagement.CafeDBDataSet cafeDBDataSet;
        private System.Windows.Forms.BindingSource cafeBindingSource;
        private CafeManagement.CafeDBDataSetTableAdapters.CafeTableAdapter cafeTableAdapter;
        private CafeManagement.CafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cafeBindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cafeBindingNavigator1SaveItem;
        private System.Windows.Forms.DataGridView cafeDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox cafeIDTextBox1;
        private System.Windows.Forms.TextBox cafeNameTextBox1;
        private System.Windows.Forms.TextBox cafeTypeTextBox1;
        private System.Windows.Forms.DateTimePicker openingDateDateTimePicker1;
        private System.Windows.Forms.TextBox priceRangeTextBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
    }
}