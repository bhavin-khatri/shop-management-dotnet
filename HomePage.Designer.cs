
namespace MyProject
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutpictureBox = new System.Windows.Forms.PictureBox();
            this.CustomerpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AddProductpictureBox = new System.Windows.Forms.PictureBox();
            this.AddOrderpictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddOrderpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "Add Orders";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 51;
            this.label2.Text = "Manage Product";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 52;
            this.label3.Text = "Generate Bills";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(227, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 14);
            this.label4.TabIndex = 53;
            this.label4.Text = "View Customers";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LogoutpictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 376);
            this.panel1.TabIndex = 54;
            // 
            // LogoutpictureBox
            // 
            this.LogoutpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoutpictureBox.BackgroundImage = global::MyProject.Properties.Resources.logout1;
            this.LogoutpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoutpictureBox.Location = new System.Drawing.Point(390, 3);
            this.LogoutpictureBox.Name = "LogoutpictureBox";
            this.LogoutpictureBox.Size = new System.Drawing.Size(48, 48);
            this.LogoutpictureBox.TabIndex = 2;
            this.LogoutpictureBox.TabStop = false;
            this.LogoutpictureBox.Click += new System.EventHandler(this.LogoutpictureBox_Click);
            this.LogoutpictureBox.MouseHover += new System.EventHandler(this.LogoutpictureBox_MouseHover);
            // 
            // CustomerpictureBox
            // 
            this.CustomerpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerpictureBox.BackColor = System.Drawing.Color.White;
            this.CustomerpictureBox.BackgroundImage = global::MyProject.Properties.Resources.customer;
            this.CustomerpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomerpictureBox.Location = new System.Drawing.Point(230, 205);
            this.CustomerpictureBox.Name = "CustomerpictureBox";
            this.CustomerpictureBox.Size = new System.Drawing.Size(90, 90);
            this.CustomerpictureBox.TabIndex = 4;
            this.CustomerpictureBox.TabStop = false;
            this.CustomerpictureBox.Click += new System.EventHandler(this.CustomerpictureBox_Click);
            this.CustomerpictureBox.MouseHover += new System.EventHandler(this.CustomerpictureBox_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::MyProject.Properties.Resources.bill;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(119, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // AddProductpictureBox
            // 
            this.AddProductpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductpictureBox.BackColor = System.Drawing.Color.White;
            this.AddProductpictureBox.BackgroundImage = global::MyProject.Properties.Resources.choices;
            this.AddProductpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddProductpictureBox.Location = new System.Drawing.Point(230, 92);
            this.AddProductpictureBox.Name = "AddProductpictureBox";
            this.AddProductpictureBox.Size = new System.Drawing.Size(90, 90);
            this.AddProductpictureBox.TabIndex = 1;
            this.AddProductpictureBox.TabStop = false;
            this.AddProductpictureBox.Click += new System.EventHandler(this.AddProductpictureBox_Click);
            this.AddProductpictureBox.MouseHover += new System.EventHandler(this.AddProductpictureBox_MouseHover);
            // 
            // AddOrderpictureBox
            // 
            this.AddOrderpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddOrderpictureBox.BackColor = System.Drawing.Color.White;
            this.AddOrderpictureBox.BackgroundImage = global::MyProject.Properties.Resources.tracking;
            this.AddOrderpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddOrderpictureBox.Location = new System.Drawing.Point(119, 92);
            this.AddOrderpictureBox.Name = "AddOrderpictureBox";
            this.AddOrderpictureBox.Size = new System.Drawing.Size(90, 90);
            this.AddOrderpictureBox.TabIndex = 0;
            this.AddOrderpictureBox.TabStop = false;
            this.AddOrderpictureBox.Click += new System.EventHandler(this.AddOrderpictureBox_Click_1);
            this.AddOrderpictureBox.MouseHover += new System.EventHandler(this.AddOrderpictureBox_MouseHover);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(448, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerpictureBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AddProductpictureBox);
            this.Controls.Add(this.AddOrderpictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Move += new System.EventHandler(this.HomePage_Move);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddOrderpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddOrderpictureBox;
        private System.Windows.Forms.PictureBox AddProductpictureBox;
        private System.Windows.Forms.PictureBox LogoutpictureBox;
        private System.Windows.Forms.PictureBox CustomerpictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}