using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MyProject
{
    public partial class ManageProduct : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public static int G500M = 0;
        public static int G250M = 0;
        public static int K1G = 0;
        public static string PT = string.Empty;
        public static string PN = string.Empty;
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        { 

            dataGridView1.Hide();


            // TODO: This line of code loads data into the 'customer_OrderDataSet17.Product_Name' table. You can move, or remove it, as needed.
            this.product_NameTableAdapter.Fill(this.customer_OrderDataSet17.Product_Name);
            FillProductType();
            Deletebutton.Hide();
            UpdateProductbutton.Hide();
            // TODO: This line of code loads data into the 'customer_OrderDataSet16.ProductMain' table. You can move, or remove it, as needed.
            //this.productMainTableAdapter.Fill(this.customer_OrderDataSet16.ProductMain);

        }

        private void FillProductType()
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Product_Type", con);
            dt = new DataTable();
            adp.Fill(dt);
            ProductTypecomboBox.DataSource = dt;
            ProductTypecomboBox.DisplayMember = "ProductType";
            ProductTypecomboBox.ValueMember = "Pid";
        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {
            if (ProductTypecomboBox.Text == "" || ProductNametextBox.Text == "" || P250textBox.Text == "" || P500textBox.Text == "" || P1000textBox.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                int i = 0;
                //string a1 = ProductTypecomboBox.SelectedItem.ToString() ;
                string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                adp = new SqlDataAdapter("select * from Product_Name where P_id='" + ProductTypecomboBox.SelectedValue + "'", con);
                dt = new DataTable();
                adp.Fill(dt);
                //a1 = ProductTypecomboBox.SelectedItem.ToString();
                if (ProductTypecomboBox.SelectedValue.ToString() == "1")
                {
                    i = 1;

                }
                else if (ProductTypecomboBox.SelectedValue.ToString() == "2")
                {
                    i = 2;

                }
                else
                {
                    MessageBox.Show("Invalid type");
                }
                G250M = Convert.ToInt32(P250textBox.Text);
                G500M = Convert.ToInt32(P500textBox.Text);
                K1G = Convert.ToInt32(P1000textBox.Text);
                adp = new SqlDataAdapter("insert into Product_Name(ProductName,P_id,QPrice,HPrice,FPrice,Category) values('" + ProductNametextBox.Text + "','" + i + "','" + P250textBox.Text + "','" + P500textBox.Text + "','" + P1000textBox.Text + "','" + ProductTypecomboBox.Text + "')", con);
                dt = new DataTable();
                adp.Fill(dt);


                DisplayAll();
                MessageBox.Show("Product Added successfully");
                Clear();
            }
        }
        
        private void Clear()
        {
            foreach (Control Cleartext in this.Controls)
            {
                if (Cleartext is TextBox)
                {
                    ((TextBox)Cleartext).Text = string.Empty;
                }
            }
            ProductTypecomboBox.Text = string.Empty;
        }

        private void DisplayAll()
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Product_Name", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTypecomboBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ProductNametextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            P250textBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            P500textBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            P1000textBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            UpdateProductbutton.Show();
            Deletebutton.Show();

        }

        private void UpdateProductbutton_Click(object sender, EventArgs e)
        {


            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

            adp = new SqlDataAdapter("Update Product_Name Set ProductName='" + ProductNametextBox.Text + "',QPrice='" + P250textBox.Text + "',HPrice='" + P500textBox.Text + "',FPrice='" + P1000textBox.Text + "',Category ='" + ProductTypecomboBox.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            DisplayAll();
            MessageBox.Show("Product Updated successfully");
            Clear();
            UpdateProductbutton.Hide();
            Deletebutton.Hide();
            AddProductbutton.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage h = new HomePage();
            h.Show();
        }

        private void Canclebutton_Click(object sender, EventArgs e)
        {
            Cancle();

        }

        private void Cancle()
        {
            Clear();
            UpdateProductbutton.Hide();
            Deletebutton.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToggleOnpictureBox_Click(object sender, EventArgs e)
        {
            ToggleOfpictureBox.Show();
            ToggleOnpictureBox.Hide();
            dataGridView1.Hide();

        }

        private void ToggleOfpictureBox_Click(object sender, EventArgs e)
        {

            ToggleOnpictureBox.Show();
            dataGridView1.Show();
            ToggleOfpictureBox.Hide();


        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do You Want To Delete this Product?", "", buttons);
            if (result == DialogResult.Yes)
            {
                string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                adp = new SqlDataAdapter("Delete from Product_Name where Category='" + ProductTypecomboBox.Text + "'And ProductName='" + ProductNametextBox.Text + "'", con);
                dt = new DataTable();
                adp.Fill(dt);
                MessageBox.Show("Product Deleted Successfully");
            }
            else
            {

            }
            DisplayAll();
        }
    }
}
