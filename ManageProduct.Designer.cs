
namespace MyProject
{
    partial class ManageProduct
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
            this.AddProductbutton = new System.Windows.Forms.Button();
            this.UpdateProductbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductTypecomboBox = new System.Windows.Forms.ComboBox();
            this.ProductNametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.P250textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_OrderDataSet17 = new MyProject.Customer_OrderDataSet17();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.P500textBox = new System.Windows.Forms.TextBox();
            this.P1000textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.product_NameTableAdapter = new MyProject.Customer_OrderDataSet17TableAdapters.Product_NameTableAdapter();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Canclebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToggleOfpictureBox = new System.Windows.Forms.PictureBox();
            this.ToggleOnpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderDataSet17)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOfpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOnpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductbutton
            // 
            this.AddProductbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductbutton.BackColor = System.Drawing.Color.Lime;
            this.AddProductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductbutton.Location = new System.Drawing.Point(460, 81);
            this.AddProductbutton.Name = "AddProductbutton";
            this.AddProductbutton.Size = new System.Drawing.Size(122, 25);
            this.AddProductbutton.TabIndex = 0;
            this.AddProductbutton.Text = "Add Product";
            this.AddProductbutton.UseVisualStyleBackColor = false;
            this.AddProductbutton.Click += new System.EventHandler(this.AddProductbutton_Click);
            // 
            // UpdateProductbutton
            // 
            this.UpdateProductbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateProductbutton.BackColor = System.Drawing.Color.Aqua;
            this.UpdateProductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProductbutton.Location = new System.Drawing.Point(460, 148);
            this.UpdateProductbutton.Name = "UpdateProductbutton";
            this.UpdateProductbutton.Size = new System.Drawing.Size(122, 25);
            this.UpdateProductbutton.TabIndex = 1;
            this.UpdateProductbutton.Text = "Update Product";
            this.UpdateProductbutton.UseVisualStyleBackColor = false;
            this.UpdateProductbutton.Click += new System.EventHandler(this.UpdateProductbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Type :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name :";
            // 
            // ProductTypecomboBox
            // 
            this.ProductTypecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTypecomboBox.FormattingEnabled = true;
            this.ProductTypecomboBox.Location = new System.Drawing.Point(333, 82);
            this.ProductTypecomboBox.Name = "ProductTypecomboBox";
            this.ProductTypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductTypecomboBox.TabIndex = 4;
            // 
            // ProductNametextBox
            // 
            this.ProductNametextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNametextBox.Location = new System.Drawing.Point(333, 109);
            this.ProductNametextBox.Name = "ProductNametextBox";
            this.ProductNametextBox.Size = new System.Drawing.Size(121, 20);
            this.ProductNametextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(171, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "250gm Price :";
            // 
            // P250textBox
            // 
            this.P250textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P250textBox.Location = new System.Drawing.Point(333, 137);
            this.P250textBox.Name = "P250textBox";
            this.P250textBox.Size = new System.Drawing.Size(121, 20);
            this.P250textBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pnidDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.qPriceDataGridViewTextBoxColumn,
            this.hPriceDataGridViewTextBoxColumn,
            this.fPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productNameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 423);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnidDataGridViewTextBoxColumn
            // 
            this.pnidDataGridViewTextBoxColumn.DataPropertyName = "Pnid";
            this.pnidDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.pnidDataGridViewTextBoxColumn.Name = "pnidDataGridViewTextBoxColumn";
            this.pnidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Product Type";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 120;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // qPriceDataGridViewTextBoxColumn
            // 
            this.qPriceDataGridViewTextBoxColumn.DataPropertyName = "QPrice";
            this.qPriceDataGridViewTextBoxColumn.HeaderText = "Price(250gm)";
            this.qPriceDataGridViewTextBoxColumn.Name = "qPriceDataGridViewTextBoxColumn";
            // 
            // hPriceDataGridViewTextBoxColumn
            // 
            this.hPriceDataGridViewTextBoxColumn.DataPropertyName = "HPrice";
            this.hPriceDataGridViewTextBoxColumn.HeaderText = "Price(500gm)";
            this.hPriceDataGridViewTextBoxColumn.Name = "hPriceDataGridViewTextBoxColumn";
            // 
            // fPriceDataGridViewTextBoxColumn
            // 
            this.fPriceDataGridViewTextBoxColumn.DataPropertyName = "FPrice";
            this.fPriceDataGridViewTextBoxColumn.HeaderText = "Price(1KG)";
            this.fPriceDataGridViewTextBoxColumn.Name = "fPriceDataGridViewTextBoxColumn";
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "Product_Name";
            this.productNameBindingSource.DataSource = this.customer_OrderDataSet17;
            // 
            // customer_OrderDataSet17
            // 
            this.customer_OrderDataSet17.DataSetName = "Customer_OrderDataSet17";
            this.customer_OrderDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "500gm Price :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(171, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "1Kg Price :";
            // 
            // P500textBox
            // 
            this.P500textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P500textBox.Location = new System.Drawing.Point(333, 163);
            this.P500textBox.Name = "P500textBox";
            this.P500textBox.Size = new System.Drawing.Size(121, 20);
            this.P500textBox.TabIndex = 15;
            // 
            // P1000textBox
            // 
            this.P1000textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P1000textBox.Location = new System.Drawing.Point(333, 189);
            this.P1000textBox.Name = "P1000textBox";
            this.P1000textBox.Size = new System.Drawing.Size(121, 20);
            this.P1000textBox.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(199, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(398, 56);
            this.label13.TabIndex = 49;
            this.label13.Text = "Manage Product";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // product_NameTableAdapter
            // 
            this.product_NameTableAdapter.ClearBeforeFill = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deletebutton.BackColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(460, 182);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(122, 25);
            this.Deletebutton.TabIndex = 52;
            this.Deletebutton.Text = "Delete Product";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Canclebutton
            // 
            this.Canclebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Canclebutton.BackColor = System.Drawing.Color.Yellow;
            this.Canclebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Canclebutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canclebutton.Location = new System.Drawing.Point(460, 114);
            this.Canclebutton.Name = "Canclebutton";
            this.Canclebutton.Size = new System.Drawing.Size(122, 25);
            this.Canclebutton.TabIndex = 53;
            this.Canclebutton.Text = "Cancle";
            this.Canclebutton.UseVisualStyleBackColor = false;
            this.Canclebutton.Click += new System.EventHandler(this.Canclebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ToggleOfpictureBox);
            this.panel1.Controls.Add(this.ToggleOnpictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 660);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::MyProject.Properties.Resources.back_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 56);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ToggleOfpictureBox
            // 
            this.ToggleOfpictureBox.BackgroundImage = global::MyProject.Properties.Resources.toggle_off;
            this.ToggleOfpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToggleOfpictureBox.Location = new System.Drawing.Point(660, 191);
            this.ToggleOfpictureBox.Name = "ToggleOfpictureBox";
            this.ToggleOfpictureBox.Size = new System.Drawing.Size(79, 38);
            this.ToggleOfpictureBox.TabIndex = 52;
            this.ToggleOfpictureBox.TabStop = false;
            this.ToggleOfpictureBox.Click += new System.EventHandler(this.ToggleOfpictureBox_Click);
            // 
            // ToggleOnpictureBox
            // 
            this.ToggleOnpictureBox.BackgroundImage = global::MyProject.Properties.Resources.toggle_on;
            this.ToggleOnpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToggleOnpictureBox.Location = new System.Drawing.Point(660, 191);
            this.ToggleOnpictureBox.Name = "ToggleOnpictureBox";
            this.ToggleOnpictureBox.Size = new System.Drawing.Size(79, 38);
            this.ToggleOnpictureBox.TabIndex = 0;
            this.ToggleOnpictureBox.TabStop = false;
            this.ToggleOnpictureBox.Click += new System.EventHandler(this.ToggleOnpictureBox_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 661);
            this.Controls.Add(this.Canclebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.P1000textBox);
            this.Controls.Add(this.P500textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P250textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductNametextBox);
            this.Controls.Add(this.ProductTypecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateProductbutton);
            this.Controls.Add(this.AddProductbutton);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrderDataSet17)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOfpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOnpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductbutton;
        private System.Windows.Forms.Button UpdateProductbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProductTypecomboBox;
        private System.Windows.Forms.TextBox ProductNametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox P250textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox P500textBox;
        private System.Windows.Forms.TextBox P1000textBox;
        private System.Windows.Forms.Label label13;
        private Customer_OrderDataSet17 customer_OrderDataSet17;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private Customer_OrderDataSet17TableAdapters.Product_NameTableAdapter product_NameTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Canclebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox ToggleOnpictureBox;
        private System.Windows.Forms.PictureBox ToggleOfpictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}