
namespace MyProject
{
    partial class Order_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerNametextBox = new System.Windows.Forms.TextBox();
            this.CustomerPhonetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NOUtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerAddresstextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerMailtextBox = new System.Windows.Forms.TextBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_OrderDataSet13 = new MyProject.Customer_OrderDataSet13();
            this.ProductNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton_250 = new System.Windows.Forms.RadioButton();
            this.radioButton_1k = new System.Windows.Forms.RadioButton();
            this.radioButton_500 = new System.Windows.Forms.RadioButton();
            this.CustomerIDtextBox = new System.Windows.Forms.TextBox();
            this.ShippingdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OrderdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.main_TableTableAdapter = new MyProject.Customer_OrderDataSet13TableAdapters.Main_TableTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.Canclebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number   :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(753, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Date       :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(754, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shipping Date :";
            // 
            // CustomerNametextBox
            // 
            this.CustomerNametextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNametextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerNametextBox.Location = new System.Drawing.Point(213, 114);
            this.CustomerNametextBox.Name = "CustomerNametextBox";
            this.CustomerNametextBox.Size = new System.Drawing.Size(121, 20);
            this.CustomerNametextBox.TabIndex = 6;
            this.CustomerNametextBox.TextChanged += new System.EventHandler(this.CustomerNametextBox_TextChanged);
            // 
            // CustomerPhonetextBox
            // 
            this.CustomerPhonetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerPhonetextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerPhonetextBox.Location = new System.Drawing.Point(213, 141);
            this.CustomerPhonetextBox.Name = "CustomerPhonetextBox";
            this.CustomerPhonetextBox.Size = new System.Drawing.Size(121, 20);
            this.CustomerPhonetextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(369, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Product Name :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(369, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity           :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // NOUtextBox
            // 
            this.NOUtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NOUtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NOUtextBox.Location = new System.Drawing.Point(527, 167);
            this.NOUtextBox.Name = "NOUtextBox";
            this.NOUtextBox.Size = new System.Drawing.Size(193, 20);
            this.NOUtextBox.TabIndex = 16;
            this.NOUtextBox.TextChanged += new System.EventHandler(this.NOUtextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer City    :";
            // 
            // CustomerAddresstextBox
            // 
            this.CustomerAddresstextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerAddresstextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerAddresstextBox.Location = new System.Drawing.Point(213, 168);
            this.CustomerAddresstextBox.Name = "CustomerAddresstextBox";
            this.CustomerAddresstextBox.Size = new System.Drawing.Size(121, 20);
            this.CustomerAddresstextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email Id                :";
            // 
            // CustomerMailtextBox
            // 
            this.CustomerMailtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerMailtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerMailtextBox.Location = new System.Drawing.Point(213, 195);
            this.CustomerMailtextBox.Name = "CustomerMailtextBox";
            this.CustomerMailtextBox.Size = new System.Drawing.Size(121, 20);
            this.CustomerMailtextBox.TabIndex = 20;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deletebutton.BackColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(750, 243);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(112, 33);
            this.Deletebutton.TabIndex = 24;
            this.Deletebutton.Text = "Delete Order";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            this.Deletebutton.MouseHover += new System.EventHandler(this.Deletebutton_MouseHover);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Updatebutton.BackColor = System.Drawing.Color.Aqua;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(234, 243);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(112, 33);
            this.Updatebutton.TabIndex = 25;
            this.Updatebutton.Text = "Update Order";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            this.Updatebutton.MouseHover += new System.EventHandler(this.Updatebutton_MouseHover);
            // 
            // Insertbutton
            // 
            this.Insertbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Insertbutton.BackColor = System.Drawing.Color.Lime;
            this.Insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbutton.Location = new System.Drawing.Point(402, 243);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(112, 33);
            this.Insertbutton.TabIndex = 27;
            this.Insertbutton.Text = "Add Order";
            this.Insertbutton.UseVisualStyleBackColor = false;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            this.Insertbutton.MouseHover += new System.EventHandler(this.Insertbutton_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerPhoneNoDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.mailIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.shippingDateDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Price,
            this.noOfUnitsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mainTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1138, 219);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneNoDataGridViewTextBoxColumn
            // 
            this.customerPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNo";
            this.customerPhoneNoDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNo";
            this.customerPhoneNoDataGridViewTextBoxColumn.Name = "customerPhoneNoDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // mailIdDataGridViewTextBoxColumn
            // 
            this.mailIdDataGridViewTextBoxColumn.DataPropertyName = "MailId";
            this.mailIdDataGridViewTextBoxColumn.HeaderText = "MailId";
            this.mailIdDataGridViewTextBoxColumn.Name = "mailIdDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // shippingDateDataGridViewTextBoxColumn
            // 
            this.shippingDateDataGridViewTextBoxColumn.DataPropertyName = "ShippingDate";
            this.shippingDateDataGridViewTextBoxColumn.HeaderText = "ShippingDate";
            this.shippingDateDataGridViewTextBoxColumn.Name = "shippingDateDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // noOfUnitsDataGridViewTextBoxColumn
            // 
            this.noOfUnitsDataGridViewTextBoxColumn.DataPropertyName = "No_Of_Units";
            this.noOfUnitsDataGridViewTextBoxColumn.HeaderText = "No_Of_Units";
            this.noOfUnitsDataGridViewTextBoxColumn.Name = "noOfUnitsDataGridViewTextBoxColumn";
            // 
            // mainTableBindingSource
            // 
            this.mainTableBindingSource.DataMember = "Main_Table";
            this.mainTableBindingSource.DataSource = this.customer_OrderDataSet13;
            // 
            // customer_OrderDataSet13
            // 
            this.customer_OrderDataSet13.DataSetName = "Customer_OrderDataSet13";
            this.customer_OrderDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductNamecomboBox
            // 
            this.ProductNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNamecomboBox.FormattingEnabled = true;
            this.ProductNamecomboBox.Location = new System.Drawing.Point(527, 116);
            this.ProductNamecomboBox.Name = "ProductNamecomboBox";
            this.ProductNamecomboBox.Size = new System.Drawing.Size(193, 21);
            this.ProductNamecomboBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Product Type  :";
            // 
            // ProductTypecomboBox
            // 
            this.ProductTypecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTypecomboBox.FormattingEnabled = true;
            this.ProductTypecomboBox.Location = new System.Drawing.Point(527, 88);
            this.ProductTypecomboBox.Name = "ProductTypecomboBox";
            this.ProductTypecomboBox.Size = new System.Drawing.Size(193, 21);
            this.ProductTypecomboBox.TabIndex = 36;
            this.ProductTypecomboBox.SelectionChangeCommitted += new System.EventHandler(this.ProductTypecomboBox_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(369, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "No of Units       :";
            // 
            // radioButton_250
            // 
            this.radioButton_250.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_250.AutoSize = true;
            this.radioButton_250.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_250.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_250.ForeColor = System.Drawing.Color.White;
            this.radioButton_250.Location = new System.Drawing.Point(536, 143);
            this.radioButton_250.Name = "radioButton_250";
            this.radioButton_250.Size = new System.Drawing.Size(67, 20);
            this.radioButton_250.TabIndex = 38;
            this.radioButton_250.TabStop = true;
            this.radioButton_250.Text = "250gm";
            this.radioButton_250.UseVisualStyleBackColor = false;
            this.radioButton_250.Click += new System.EventHandler(this.radioButton_250_Click);
            // 
            // radioButton_1k
            // 
            this.radioButton_1k.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_1k.AutoSize = true;
            this.radioButton_1k.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_1k.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_1k.ForeColor = System.Drawing.Color.White;
            this.radioButton_1k.Location = new System.Drawing.Point(676, 143);
            this.radioButton_1k.Name = "radioButton_1k";
            this.radioButton_1k.Size = new System.Drawing.Size(50, 20);
            this.radioButton_1k.TabIndex = 41;
            this.radioButton_1k.TabStop = true;
            this.radioButton_1k.Text = "1Kg";
            this.radioButton_1k.UseVisualStyleBackColor = false;
            // 
            // radioButton_500
            // 
            this.radioButton_500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_500.AutoSize = true;
            this.radioButton_500.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_500.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_500.ForeColor = System.Drawing.Color.White;
            this.radioButton_500.Location = new System.Drawing.Point(603, 143);
            this.radioButton_500.Name = "radioButton_500";
            this.radioButton_500.Size = new System.Drawing.Size(67, 20);
            this.radioButton_500.TabIndex = 42;
            this.radioButton_500.TabStop = true;
            this.radioButton_500.Text = "500gm";
            this.radioButton_500.UseVisualStyleBackColor = false;
            // 
            // CustomerIDtextBox
            // 
            this.CustomerIDtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerIDtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CustomerIDtextBox.Location = new System.Drawing.Point(213, 88);
            this.CustomerIDtextBox.Name = "CustomerIDtextBox";
            this.CustomerIDtextBox.Size = new System.Drawing.Size(121, 20);
            this.CustomerIDtextBox.TabIndex = 43;
            // 
            // ShippingdateTimePicker
            // 
            this.ShippingdateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShippingdateTimePicker.Location = new System.Drawing.Point(906, 117);
            this.ShippingdateTimePicker.Name = "ShippingdateTimePicker";
            this.ShippingdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ShippingdateTimePicker.TabIndex = 45;
            this.ShippingdateTimePicker.Value = new System.DateTime(2021, 1, 2, 15, 40, 7, 0);
            // 
            // OrderdateTimePicker
            // 
            this.OrderdateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderdateTimePicker.Location = new System.Drawing.Point(906, 90);
            this.OrderdateTimePicker.Name = "OrderdateTimePicker";
            this.OrderdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.OrderdateTimePicker.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(401, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(348, 75);
            this.label13.TabIndex = 48;
            this.label13.Text = "Add Order";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // main_TableTableAdapter
            // 
            this.main_TableTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Customer Id        :";
            // 
            // Canclebutton
            // 
            this.Canclebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Canclebutton.BackColor = System.Drawing.Color.Yellow;
            this.Canclebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Canclebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canclebutton.Location = new System.Drawing.Point(580, 243);
            this.Canclebutton.Name = "Canclebutton";
            this.Canclebutton.Size = new System.Drawing.Size(112, 33);
            this.Canclebutton.TabIndex = 51;
            this.Canclebutton.Text = "Cancle";
            this.Canclebutton.UseVisualStyleBackColor = false;
            this.Canclebutton.Click += new System.EventHandler(this.Canclebutton_Click);
            this.Canclebutton.MouseHover += new System.EventHandler(this.Canclebutton_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyProject.Properties.Resources.back_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 56);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PricetextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 520);
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PricetextBox
            // 
            this.PricetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PricetextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PricetextBox.Location = new System.Drawing.Point(525, 196);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(193, 20);
            this.PricetextBox.TabIndex = 53;
            // 
            // Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1163, 520);
            this.Controls.Add(this.Canclebutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OrderdateTimePicker);
            this.Controls.Add(this.ShippingdateTimePicker);
            this.Controls.Add(this.CustomerIDtextBox);
            this.Controls.Add(this.radioButton_500);
            this.Controls.Add(this.radioButton_1k);
            this.Controls.Add(this.radioButton_250);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProductTypecomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductNamecomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.CustomerMailtextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustomerAddresstextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NOUtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustomerPhonetextBox);
            this.Controls.Add(this.CustomerNametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Order_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Order_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerNametextBox;
        private System.Windows.Forms.TextBox CustomerPhonetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NOUtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustomerAddresstextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CustomerMailtextBox;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Insertbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ProductNamecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProductTypecomboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton_250;
        private System.Windows.Forms.RadioButton radioButton_1k;
        private System.Windows.Forms.RadioButton radioButton_500;
        private System.Windows.Forms.TextBox CustomerIDtextBox;
        private System.Windows.Forms.DateTimePicker ShippingdateTimePicker;
        private System.Windows.Forms.DateTimePicker OrderdateTimePicker;
        private System.Windows.Forms.Label label13;
        private Customer_OrderDataSet13 customer_OrderDataSet13;
        private System.Windows.Forms.BindingSource mainTableBindingSource;
        private Customer_OrderDataSet13TableAdapters.Main_TableTableAdapter main_TableTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Canclebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfUnitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PricetextBox;
    }
}

