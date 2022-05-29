namespace NorthwindUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewNorthwind = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitsInStocks = new System.Windows.Forms.TextBox();
            this.lblUnitsInStocks = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddCategoryName = new System.Windows.Forms.Label();
            this.cbxAddCategoryName = new System.Windows.Forms.ComboBox();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorthwind)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNorthwind
            // 
            this.dataGridViewNorthwind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNorthwind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNorthwind.Location = new System.Drawing.Point(2, 176);
            this.dataGridViewNorthwind.Name = "dataGridViewNorthwind";
            this.dataGridViewNorthwind.RowTemplate.Height = 25;
            this.dataGridViewNorthwind.Size = new System.Drawing.Size(824, 170);
            this.dataGridViewNorthwind.TabIndex = 0;
            this.dataGridViewNorthwind.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNorthwind_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategoryName);
            this.groupBox1.Controls.Add(this.lblCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Category name";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.DisplayMember = "-1";
            this.cbxCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(143, 29);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(213, 23);
            this.cbxCategoryName.TabIndex = 1;
            this.cbxCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryName_SelectedIndexChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(33, 32);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(90, 15);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Product name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(612, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(143, 31);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(213, 23);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 34);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 15);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtUnitPrice);
            this.groupBox3.Controls.Add(this.lblUnitPrice);
            this.groupBox3.Controls.Add(this.txtUnitsInStocks);
            this.groupBox3.Controls.Add(this.lblUnitsInStocks);
            this.groupBox3.Controls.Add(this.txtQuantityPerUnit);
            this.groupBox3.Controls.Add(this.lblQuantityPerUnit);
            this.groupBox3.Controls.Add(this.lblAddCategoryName);
            this.groupBox3.Controls.Add(this.cbxAddCategoryName);
            this.groupBox3.Controls.Add(this.txtAddProductName);
            this.groupBox3.Controls.Add(this.lblAddProductName);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Process";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(635, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(635, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(427, 55);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(182, 23);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(326, 58);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtUnitsInStocks
            // 
            this.txtUnitsInStocks.Location = new System.Drawing.Point(427, 22);
            this.txtUnitsInStocks.Name = "txtUnitsInStocks";
            this.txtUnitsInStocks.Size = new System.Drawing.Size(182, 23);
            this.txtUnitsInStocks.TabIndex = 7;
            // 
            // lblUnitsInStocks
            // 
            this.lblUnitsInStocks.AutoSize = true;
            this.lblUnitsInStocks.Location = new System.Drawing.Point(326, 25);
            this.lblUnitsInStocks.Name = "lblUnitsInStocks";
            this.lblUnitsInStocks.Size = new System.Drawing.Size(84, 15);
            this.lblUnitsInStocks.TabIndex = 6;
            this.lblUnitsInStocks.Text = "Units In Stocks";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(120, 84);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(182, 23);
            this.txtQuantityPerUnit.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(10, 87);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(98, 15);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblAddCategoryName
            // 
            this.lblAddCategoryName.AutoSize = true;
            this.lblAddCategoryName.Location = new System.Drawing.Point(10, 58);
            this.lblAddCategoryName.Name = "lblAddCategoryName";
            this.lblAddCategoryName.Size = new System.Drawing.Size(90, 15);
            this.lblAddCategoryName.TabIndex = 3;
            this.lblAddCategoryName.Text = "Category Name";
            // 
            // cbxAddCategoryName
            // 
            this.cbxAddCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddCategoryName.FormattingEnabled = true;
            this.cbxAddCategoryName.Location = new System.Drawing.Point(120, 55);
            this.cbxAddCategoryName.Name = "cbxAddCategoryName";
            this.cbxAddCategoryName.Size = new System.Drawing.Size(182, 23);
            this.cbxAddCategoryName.TabIndex = 2;
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Location = new System.Drawing.Point(120, 22);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(182, 23);
            this.txtAddProductName.TabIndex = 1;
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(10, 25);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(84, 15);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Product Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewNorthwind);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorthwind)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewNorthwind;
        private GroupBox groupBox1;
        private ComboBox cbxCategoryName;
        private Label lblCategoryName;
        private GroupBox groupBox2;
        private TextBox txtProductName;
        private Label lblProductName;
        private Button btnDelete;
        private GroupBox groupBox3;
        private ComboBox cbxAddCategoryName;
        private TextBox txtAddProductName;
        private Label lblAddProductName;
        private Label lblAddCategoryName;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtUnitsInStocks;
        private Label lblUnitsInStocks;
        private TextBox txtQuantityPerUnit;
        private Label lblQuantityPerUnit;
    }
}