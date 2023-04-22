using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Customer_Bill : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
       
        public Customer_Bill()
        {
            InitializeComponent();
        }

        private int id = 0;
        private void Customer_Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customer_OrderDataSet11.Main_Table' table. You can move, or remove it, as needed.
            ///  this.main_TableTableAdapter.Fill(this.customer_OrderDataSet11.Main_Table);
            InvoicetextBox.Text = id.ToString("0000000");
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
             adp = new SqlDataAdapter("select * from Customer", con);
            dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CustomerName";
            comboBox1.ValueMember = "CustomerId";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from [Order] where CustomerId='" + comboBox1.SelectedValue + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            OrderDatecomboBox.DataSource = dt;
            OrderDatecomboBox.DisplayMember = "OrderDate";
            OrderDatecomboBox.ValueMember = "OrderId";
        }

        private void GenerateBillbutton_Click(object sender, EventArgs e)
        {
            id += 1;
            InvoicetextBox.Text = id.ToString("0000000");
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table where CustomerName='" + comboBox1.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Customer_NametextBox.Text = dt.Rows[0][1].ToString();
                Customer_PhonetextBox.Text = dt.Rows[0][2].ToString();
                Customer_AddresstextBox.Text = dt.Rows[0][3].ToString();


                //  CustomerNametextBox.Text = dt.Rows[0][1].ToString();
            }
            Order_DatetextBox.Text = System.DateTime.Now.ToString();
            GSTtextBox.Text = "5%";
            // string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select ProductName,ProductType,Quantity,Price,No_Of_Units,Total from Main_Table where CustomerName='" + comboBox1.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;

            int sum = 0;
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                row.Cells[5].Value = Convert.ToDouble(row.Cells[3].Value) * Convert.ToDouble(row.Cells[4].Value);
                sum += Convert.ToInt32(row.Cells[5].Value);
            }
            total = Convert.ToInt32(sum) + Convert.ToInt32((sum * 0.05));
            FinalBilltextBox.Text = total.ToString();
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage d1 = new HomePage();
            d1.Show();
        }
        Bitmap bp;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Print(this.Billpanel);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        public void Print(Panel pnl)
        {
            Billpanel = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void Customer_NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(pictureBox1, "Back Button");
        }

        private void PrintpictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(PrintpictureBox, "Print Bill");
        }

        private void GenerateBillbutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(GenerateBillbutton, "Generate Bill");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                row.Cells[5].Value = Convert.ToDouble(row.Cells[3].Value) * Convert.ToDouble(row.Cells[4].Value);
                sum += Convert.ToInt32(row.Cells[5].Value);
            }
            total = Convert.ToInt32(sum) + Convert.ToInt32((sum * 0.05));
            FinalBilltextBox.Text = total.ToString();
           
        }

       
    }
}
