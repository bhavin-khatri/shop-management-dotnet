using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MyProject
{
    public partial class Order_Details : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        SqlCommand cmd;
        SqlDataReader dr;
       
        public Order_Details()
        {
            InitializeComponent();
        }


        private void Order_Details_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'customer_OrderDataSet13.Main_Table' table. You can move, or remove it, as needed.
            this.main_TableTableAdapter.Fill(this.customer_OrderDataSet13.Main_Table);
            FillProductType();
       
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table", con);
            dt = new DataTable();
            adp.Fill(dt);
            DisplayAll();
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
        String q;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhonetextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            CustomerAddresstextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CustomerMailtextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            OrderdateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            ShippingdateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //OrderStatustextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            ProductTypecomboBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            ProductNamecomboBox.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            q = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            if (q == "250gm")
            {
                radioButton_250.Checked = true;
            }
            else if (q == "500gm")
            {
                radioButton_500.Checked = true;
            }
            else
            {
                radioButton_1k.Checked = true;
            }
            NOUtextBox.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Updatebutton.Show();
            Deletebutton.Show();
        }


        private void Insertbutton_Click(object sender, EventArgs e)
        {
            if (CustomerIDtextBox.Text == "" || CustomerNametextBox.Text == "" || CustomerAddresstextBox.Text == "" || CustomerPhonetextBox.Text == "" || ProductTypecomboBox.Text == "" || ProductNamecomboBox.Text == "" || NOUtextBox.Text == "" || OrderdateTimePicker.Text == "" || ShippingdateTimePicker.Text == "")
            {
                MessageBox.Show("All Fields are Required!!");
            }
            else
            {
                string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                int PricePerBox = 0;
                adp = new SqlDataAdapter("select * from Main_Table,Product_Name where Main_Table.ProductType=Product_Name.Category AND Main_Table.ProductName=Product_Name.ProductName", con);
                dt = new DataTable();
                adp.Fill(dt);
            
                    if(radioButton_250.Checked)
                    {
                       
                        q = "250gm";
                       
                     // PricePerBox = Convert.ToInt32("Product_Name.QPrice");
                    }
                    if(radioButton_500.Checked)
                    {
                        q = "500gm";
                        PricePerBox = Convert.ToInt32(ManageProduct.G500M);
                    }
                    if(radioButton_1k.Checked)
                    {
                        q = "1Kg";
                        PricePerBox = Convert.ToInt32(ManageProduct.K1G);
                    }
               
                adp = new SqlDataAdapter("INSERT INTO Main_Table(CustomerId,CustomerName,CustomerPhoneNo,CustomerAddress,MailId,OrderDate,ShippingDate,ProductType,ProductName,Quantity,No_Of_Units) values ('" + CustomerIDtextBox.Text + "','" + CustomerNametextBox.Text + "','" + CustomerPhonetextBox.Text + "','" + CustomerAddresstextBox.Text + "','" + CustomerMailtextBox.Text + "','" + OrderdateTimePicker.Text + "','" + ShippingdateTimePicker.Text + "','" + ProductTypecomboBox.Text + "','" + ProductNamecomboBox.Text + "','" + q + "','" + NOUtextBox.Text + "') ", con);
                 dt = new DataTable();
                adp.Fill(dt);

                if (radioButton_250.Checked)
                {

                    adp = new SqlDataAdapter("UPDATE Main_Table SET Main_Table.Price=Product_Name.QPrice FROM Main_Table INNER JOIN Product_Name ON Main_Table.ProductType=Product_Name.Category and Main_Table.ProductName=Product_Name.ProductName AND Main_Table.Quantity='"+q+"'", con);
                    dt = new DataTable();
                    adp.Fill(dt);
                }
                else if(radioButton_500.Checked)
                {
                   
                    adp = new SqlDataAdapter("UPDATE Main_Table SET Main_Table.Price=Product_Name.HPrice FROM Main_Table INNER JOIN Product_Name ON Main_Table.ProductType=Product_Name.Category and Main_Table.ProductName=Product_Name.ProductName AND Main_Table.Quantity='" + q + "'", con);
                    dt = new DataTable();
                    adp.Fill(dt);
                }
                else
                {
                    adp = new SqlDataAdapter("UPDATE Main_Table SET Main_Table.Price=Product_Name.FPrice FROM Main_Table INNER JOIN Product_Name ON Main_Table.ProductType=Product_Name.Category and Main_Table.ProductName=Product_Name.ProductName AND Main_Table.Quantity='" + q + "'", con);
                    dt = new DataTable();
                    adp.Fill(dt);
                }
               
                adp = new SqlDataAdapter("select * from Customer where CustomerId='" + CustomerIDtextBox.Text + "' ", con);
                dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // MessageBox.Show("ALready Present");
                }
                else
                {
                    adp = new SqlDataAdapter("Insert into Customer values('" + CustomerIDtextBox.Text + "','" + CustomerNametextBox.Text + "','" + CustomerPhonetextBox.Text + "','" + CustomerAddresstextBox.Text + "','" + CustomerMailtextBox.Text + "')", con);
                    dt = new DataTable();
                    adp.Fill(dt);
                }

                adp = new SqlDataAdapter("select OrderDate from [Order] where OrderDate='" + OrderdateTimePicker.Text + "'", con);
                dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //   MessageBox.Show("ALready Present");
                }
                else
                {
                    //for inserting in Order table from main table
                    adp = new SqlDataAdapter("Insert into [Order](OrderDate,ShippingDate,CustomerId) values ('" + OrderdateTimePicker.Text + "','" + ShippingdateTimePicker.Text + "','" + CustomerIDtextBox.Text + "')", con);
                    dt = new DataTable();
                    adp.Fill(dt);
                }
                DisplayAll();
                MessageBox.Show("Order Inserted Successfully");
                
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
                else if (Cleartext is ComboBox)
                {
                    ((ComboBox)Cleartext).Text = string.Empty;
                }
                else if (Cleartext is RadioButton)
                {
                    ((RadioButton)Cleartext).Checked = false;
                }
                /*  if (Cleartext is RadioButton)
                  {
                      ((TextBox)Cleartext).Text = string.Empty;
                  }*/
            }

        }

        private void DisplayAll()
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Main_Table", con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (CustomerIDtextBox.Text == "" || CustomerNametextBox.Text == "" || CustomerAddresstextBox.Text == "" || CustomerPhonetextBox.Text == "" || ProductTypecomboBox.Text == "" || ProductNamecomboBox.Text == "" || NOUtextBox.Text == "" || OrderdateTimePicker.Text == "" || ShippingdateTimePicker.Text == "")
            {
                MessageBox.Show("All Fields are Required!!");
            }
            else
            {
                string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                if (radioButton_250.Checked)
                {
                    q = "250gm";
                }
                else if (radioButton_500.Checked)
                {
                    q = "500gm";
                }
                else
                {
                    q = "1Kg";
                }
                adp = new SqlDataAdapter("UPDATE Main_Table SET CustomerName='" + CustomerNametextBox.Text + "',CustomerPhoneNo='" + CustomerPhonetextBox.Text + "',CustomerAddress='" + CustomerAddresstextBox.Text + "',MailId='" + CustomerMailtextBox.Text + "',OrderDate='" + OrderdateTimePicker.Text + "',ShippingDate='" + ShippingdateTimePicker.Text + "',ProductType='" + ProductTypecomboBox.Text + "',ProductName='" + ProductNamecomboBox.Text + "',Quantity='" + q + "',No_Of_Units='" + NOUtextBox.Text + "' WHERE CustomerId='" + CustomerIDtextBox.Text + "'", con);
                dt = new DataTable();
                adp.Fill(dt);
                adp = new SqlDataAdapter("UPDATE Customer SET CustomerName='" + CustomerNametextBox.Text + "',CustomerPhoneNo='" + CustomerPhonetextBox.Text + "',CustomerAddress='" + CustomerAddresstextBox.Text + "',MailId='" + CustomerMailtextBox.Text + "' WHERE CustomerId='" + CustomerIDtextBox.Text + "'", con);
                dt = new DataTable();
                adp.Fill(dt);
                adp = new SqlDataAdapter("UPDATE [Order] SET OrderDate='" + OrderdateTimePicker.Text + "',ShippingDate='" + ShippingdateTimePicker.Text + "' WHERE CustomerId='" + CustomerIDtextBox.Text + "'", con);
                dt = new DataTable();
                adp.Fill(dt);
                DisplayAll();
                MessageBox.Show("Order Updated Successfully");
                Cancle();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Order_Details O = new Order_Details();
            this.Hide();
            LoginAdmin A = new LoginAdmin();
            A.Show();
        }

        private void ProductTypecomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Product_Name where P_id=" + ProductTypecomboBox.SelectedValue, con);
            dt = new DataTable();
            adp.Fill(dt);
            ProductNamecomboBox.DataSource = dt;
            ProductNamecomboBox.DisplayMember = "ProductName";
            ProductNamecomboBox.ValueMember = "Pnid";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NOUtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateBillbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Bill b1 = new Customer_Bill();
            b1.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do You Want To Delete this Order??","",buttons);
            if(result == DialogResult.Yes)
            {

               /* foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }*/

                string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                adp = new SqlDataAdapter("DELETE from Main_Table where CustomerId='" + CustomerIDtextBox.Text + "' and ProductType='"+ProductTypecomboBox.Text+"' and ProductName='"+ProductNamecomboBox.Text+"' and Quantity='"+q+"' ", con);
                dt = new DataTable();
                adp.Fill(dt);
                
                MessageBox.Show("Order Deleted Successfully");
                adp = new SqlDataAdapter("Select * from Main_Table , Customer where Main_Table.CustomerId=Customer.CustomerId", con);
                dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count>1)
                {
                  MessageBox.Show("deleted");
                }
             
                else
                {
                    adp = new SqlDataAdapter("DELETE from Customer where CustomerId='" + CustomerIDtextBox.Text + "'", con);
                    dt = new DataTable();
                    adp.Fill(dt);
                }

                /*   adp = new SqlDataAdapter("DELETE from [Order] where CustomerId='" + CustomerIDtextBox.Text + "'", con);
                   dt = new DataTable();
                   adp.Fill(dt);*/
                DisplayAll();
                Cancle();
            }
            else
            {

            }
           

           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            this.Hide();
            h.Show();
        }


        private void Canclebutton_Click(object sender, EventArgs e)
        {
            Cancle();
        }

        private void Cancle()
        {
            Clear();
            Updatebutton.Hide();
            Deletebutton.Hide();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(pictureBox1, "Back Button");
        }

        private void Updatebutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(Updatebutton, "Update Order Button");
        }

        private void Insertbutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(Insertbutton, "Add Order Button");
        }

        private void Canclebutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(Canclebutton, "Cancle Button");
        }

        private void Deletebutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(Deletebutton, "Delete Order Button");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_250_Click(object sender, EventArgs e)
        {
            
          
           /* string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Product_Name,Main_Table where Product_Name.Category=Main_Table.ProductType", con);
            dt = new DataTable();
            adp.Fill(dt);
            if(dt.Rows.Count>0)
            {
                
                 adp = new SqlDataAdapter("select QPrice from Product_Name", con);
                 dt = new DataTable();
                 adp.Fill(dt);

                 for (int i = 0; i < dt.Rows.Count; i++)
                 {
                    ManageProduct m1 = new ManageProduct();
                    PricetextBox.Text =m1.dataGridView1.Rows[i].Cells[3].te;
                  }
            
            }*/
           
        }
    }
}
