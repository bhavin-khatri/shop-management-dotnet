using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyProject
{
    public partial class ViewCustomers : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table ", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'customer_OrderDataSet18.Main_Table' table. You can move, or remove it, as needed.
            this.main_TableTableAdapter.Fill(this.customer_OrderDataSet18.Main_Table);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table where CustomerName='" + textBox1.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table where CustomerAddress='" + textBox2.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table where CustomerPhoneNo='" + textBox3.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table where CustomerName='" + textBox1.Text + "' AND CustomerPhoneNo='" + textBox3.Text + "' AND CustomerAddress='" + textBox2.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BackpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage p = new HomePage();
            p.Show();
        }
    }
}
