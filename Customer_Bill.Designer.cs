
namespace MyProject
{
    partial class Customer_Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Bill));
            this.Billpanel = new System.Windows.Forms.Panel();
            this.InvoicetextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Customer_NametextBox = new System.Windows.Forms.TextBox();
            this.GSTtextBox = new System.Windows.Forms.TextBox();
            this.FinalBilltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfUnitsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_OrderDataSet11 = new MyProject.Customer_OrderDataSet11();
            this.Order_DatetextBox = new System.Windows.Forms.TextBox();
            this.Customer_PhonetextBox = new System.Windows.Forms.TextBox();
            this.Customer_AddresstextBox = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GenerateBillbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderDatecomboBox = new System.Windows.Forms.ComboBox();
            this.main_TableTableAdapter = new MyProject.Customer_OrderDataSet11TableAdapters.Main_TableTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintpictureBox = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Billpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Billpanel
            // 
            this.Billpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Billpanel.AutoSize = true;
            this.Billpanel.BackColor = System.Drawing.Color.White;
            this.Billpanel.Controls.Add(this.InvoicetextBox);
            this.Billpanel.Controls.Add(this.panel3);
            this.Billpanel.Controls.Add(this.panel1);
            this.Billpanel.Controls.Add(this.Customer_NametextBox);
            this.Billpanel.Controls.Add(this.GSTtextBox);
            this.Billpanel.Controls.Add(this.FinalBilltextBox);
            this.Billpanel.Controls.Add(this.label8);
            this.Billpanel.Controls.Add(this.label7);
            this.Billpanel.Controls.Add(this.panel2);
            this.Billpanel.Controls.Add(this.dataGridView1);
            this.Billpanel.Controls.Add(this.Order_DatetextBox);
            this.Billpanel.Controls.Add(this.Customer_PhonetextBox);
            this.Billpanel.Controls.Add(this.Customer_AddresstextBox);
            this.Billpanel.Location = new System.Drawing.Point(292, 12);
            this.Billpanel.Name = "Billpanel";
            this.Billpanel.Size = new System.Drawing.Size(636, 536);
            this.Billpanel.TabIndex = 0;
            // 
            // InvoicetextBox
            // 
            this.InvoicetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvoicetextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.InvoicetextBox.BackColor = System.Drawing.Color.White;
            this.InvoicetextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InvoicetextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicetextBox.Location = new System.Drawing.Point(277, 202);
            this.InvoicetextBox.Multiline = true;
            this.InvoicetextBox.Name = "InvoicetextBox";
            this.InvoicetextBox.ReadOnly = true;
            this.InvoicetextBox.Size = new System.Drawing.Size(95, 25);
            this.InvoicetextBox.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(5, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 45);
            this.panel3.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(39, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(529, 41);
            this.label10.TabIndex = 23;
            this.label10.Text = "SHREENATHJI GURU UDHYOG";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 41);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "CUSTOMER NAME";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(474, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "MOBILE NO.";
            // 
            // Customer_NametextBox
            // 
            this.Customer_NametextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer_NametextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Customer_NametextBox.BackColor = System.Drawing.Color.White;
            this.Customer_NametextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Customer_NametextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_NametextBox.Location = new System.Drawing.Point(8, 116);
            this.Customer_NametextBox.Multiline = true;
            this.Customer_NametextBox.Name = "Customer_NametextBox";
            this.Customer_NametextBox.ReadOnly = true;
            this.Customer_NametextBox.Size = new System.Drawing.Size(200, 25);
            this.Customer_NametextBox.TabIndex = 23;
            this.Customer_NametextBox.TextChanged += new System.EventHandler(this.Customer_NametextBox_TextChanged);
            // 
            // GSTtextBox
            // 
            this.GSTtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GSTtextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.GSTtextBox.BackColor = System.Drawing.Color.White;
            this.GSTtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GSTtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GSTtextBox.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GSTtextBox.Location = new System.Drawing.Point(464, 472);
            this.GSTtextBox.Name = "GSTtextBox";
            this.GSTtextBox.ReadOnly = true;
            this.GSTtextBox.Size = new System.Drawing.Size(108, 19);
            this.GSTtextBox.TabIndex = 54;
            // 
            // FinalBilltextBox
            // 
            this.FinalBilltextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalBilltextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.FinalBilltextBox.BackColor = System.Drawing.Color.White;
            this.FinalBilltextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinalBilltextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FinalBilltextBox.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalBilltextBox.Location = new System.Drawing.Point(465, 500);
            this.FinalBilltextBox.Name = "FinalBilltextBox";
            this.FinalBilltextBox.ReadOnly = true;
            this.FinalBilltextBox.Size = new System.Drawing.Size(108, 19);
            this.FinalBilltextBox.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(383, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 52;
            this.label8.Text = "TOTAL:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(407, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "GST:";
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(5, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 42);
            this.panel2.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(258, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 27);
            this.label11.TabIndex = 48;
            this.label11.Text = "Invoice No.";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(546, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(425, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "CITY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = " ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.noOfUnitsDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.mainTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(2, 233);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(631, 233);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn1
            // 
            this.productTypeDataGridViewTextBoxColumn1.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.productTypeDataGridViewTextBoxColumn1.Name = "productTypeDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Category";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // noOfUnitsDataGridViewTextBoxColumn1
            // 
            this.noOfUnitsDataGridViewTextBoxColumn1.DataPropertyName = "No_Of_Units";
            this.noOfUnitsDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.noOfUnitsDataGridViewTextBoxColumn1.Name = "noOfUnitsDataGridViewTextBoxColumn1";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // mainTableBindingSource
            // 
            this.mainTableBindingSource.DataMember = "Main_Table";
            this.mainTableBindingSource.DataSource = this.customer_OrderDataSet11;
            // 
            // customer_OrderDataSet11
            // 
            this.customer_OrderDataSet11.DataSetName = "Customer_OrderDataSet11";
            this.customer_OrderDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Order_DatetextBox
            // 
            this.Order_DatetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Order_DatetextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Order_DatetextBox.BackColor = System.Drawing.Color.White;
            this.Order_DatetextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Order_DatetextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_DatetextBox.Location = new System.Drawing.Point(475, 201);
            this.Order_DatetextBox.Multiline = true;
            this.Order_DatetextBox.Name = "Order_DatetextBox";
            this.Order_DatetextBox.ReadOnly = true;
            this.Order_DatetextBox.Size = new System.Drawing.Size(146, 25);
            this.Order_DatetextBox.TabIndex = 48;
            // 
            // Customer_PhonetextBox
            // 
            this.Customer_PhonetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer_PhonetextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Customer_PhonetextBox.BackColor = System.Drawing.Color.White;
            this.Customer_PhonetextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Customer_PhonetextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_PhonetextBox.Location = new System.Drawing.Point(474, 116);
            this.Customer_PhonetextBox.Multiline = true;
            this.Customer_PhonetextBox.Name = "Customer_PhonetextBox";
            this.Customer_PhonetextBox.ReadOnly = true;
            this.Customer_PhonetextBox.Size = new System.Drawing.Size(146, 25);
            this.Customer_PhonetextBox.TabIndex = 24;
            // 
            // Customer_AddresstextBox
            // 
            this.Customer_AddresstextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer_AddresstextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Customer_AddresstextBox.BackColor = System.Drawing.Color.White;
            this.Customer_AddresstextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Customer_AddresstextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_AddresstextBox.Location = new System.Drawing.Point(8, 201);
            this.Customer_AddresstextBox.Multiline = true;
            this.Customer_AddresstextBox.Name = "Customer_AddresstextBox";
            this.Customer_AddresstextBox.ReadOnly = true;
            this.Customer_AddresstextBox.Size = new System.Drawing.Size(200, 25);
            this.Customer_AddresstextBox.TabIndex = 26;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 120;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Frozen = true;
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Frozen = true;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price Per Box";
            this.Price.Name = "Price";
            this.Price.Width = 120;
            // 
            // noOfUnitsDataGridViewTextBoxColumn
            // 
            this.noOfUnitsDataGridViewTextBoxColumn.DataPropertyName = "No_Of_Units";
            this.noOfUnitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.noOfUnitsDataGridViewTextBoxColumn.Name = "noOfUnitsDataGridViewTextBoxColumn";
            this.noOfUnitsDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfUnitsDataGridViewTextBoxColumn.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "Total Price";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Customer Name :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // GenerateBillbutton
            // 
            this.GenerateBillbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateBillbutton.BackColor = System.Drawing.Color.Red;
            this.GenerateBillbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateBillbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBillbutton.Location = new System.Drawing.Point(74, 242);
            this.GenerateBillbutton.Name = "GenerateBillbutton";
            this.GenerateBillbutton.Size = new System.Drawing.Size(124, 27);
            this.GenerateBillbutton.TabIndex = 52;
            this.GenerateBillbutton.Text = "GENERATE BILL";
            this.GenerateBillbutton.UseVisualStyleBackColor = false;
            this.GenerateBillbutton.Click += new System.EventHandler(this.GenerateBillbutton_Click);
            this.GenerateBillbutton.MouseHover += new System.EventHandler(this.GenerateBillbutton_MouseHover);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Order Date         :";
            // 
            // OrderDatecomboBox
            // 
            this.OrderDatecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderDatecomboBox.FormattingEnabled = true;
            this.OrderDatecomboBox.Location = new System.Drawing.Point(126, 201);
            this.OrderDatecomboBox.Name = "OrderDatecomboBox";
            this.OrderDatecomboBox.Size = new System.Drawing.Size(147, 21);
            this.OrderDatecomboBox.TabIndex = 54;
            // 
            // main_TableTableAdapter
            // 
            this.main_TableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::MyProject.Properties.Resources.back_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // PrintpictureBox
            // 
            this.PrintpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintpictureBox.BackgroundImage = global::MyProject.Properties.Resources.print1;
            this.PrintpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintpictureBox.Location = new System.Drawing.Point(245, 13);
            this.PrintpictureBox.Name = "PrintpictureBox";
            this.PrintpictureBox.Size = new System.Drawing.Size(44, 49);
            this.PrintpictureBox.TabIndex = 56;
            this.PrintpictureBox.TabStop = false;
            this.PrintpictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PrintpictureBox.MouseHover += new System.EventHandler(this.PrintpictureBox_MouseHover);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 554);
            this.panel4.TabIndex = 57;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Customer_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 552);
            this.Controls.Add(this.Billpanel);
            this.Controls.Add(this.PrintpictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrderDatecomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenerateBillbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Name = "Customer_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Bill_Load);
            this.Billpanel.ResumeLayout(false);
            this.Billpanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Billpanel;
        private System.Windows.Forms.TextBox Customer_AddresstextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Customer_PhonetextBox;
        private System.Windows.Forms.TextBox Customer_NametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Order_DatetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GenerateBillbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrderDatecomboBox;
        private Customer_OrderDataSet11 customer_OrderDataSet11;
        private System.Windows.Forms.BindingSource mainTableBindingSource;
        private Customer_OrderDataSet11TableAdapters.Main_TableTableAdapter main_TableTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FinalBilltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox GSTtextBox;
        private System.Windows.Forms.PictureBox PrintpictureBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfUnitsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox InvoicetextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
    }
}