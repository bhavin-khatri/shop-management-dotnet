using System;
using System.Windows.Forms;

namespace MyProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void AddProductpictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(AddProductpictureBox, "Manage Product");
        }

        private void AddOrderpictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(AddOrderpictureBox, "Add Order");
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Bill c = new Customer_Bill();
            c.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(pictureBox3, "Generate Bill");
        }

        private void CustomerpictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(CustomerpictureBox, "View All Customers");
        }

        private void LogoutpictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(LogoutpictureBox, "Log Out");
        }

        private void LogoutpictureBox_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are You Sure You Want to Logout From System?", "", buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginAdmin l1 = new LoginAdmin();
                l1.Show();
            }
            else
            {

            }
        }

        private void AddOrderpictureBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Order_Details o = new Order_Details();
            o.Show();
        }

        private void AddProductpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProduct o = new ManageProduct();
            o.Show();
        }

        private void CustomerpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomers V1 = new ViewCustomers();
            V1.Show();
        }

        private void HomePage_Move(object sender, EventArgs e)
        {
            Top = 0; Left = 0;
            Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }
    }
}
