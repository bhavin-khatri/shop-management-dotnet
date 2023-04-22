using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyProject
{
    public partial class LoginAdmin : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
           
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            adp = new SqlDataAdapter("select ID from Admin where UserName='" + UserNametextBox.Text + "' and Password='" + PasswordtextBox.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            if (UserNametextBox.Text == "" && PasswordtextBox.Text == "")
            {
                MessageBox.Show("Enter Username And Password..");
            }
            else if (UserNametextBox.Text == "")
            {
                MessageBox.Show("Enter Username..");
            }
            else if (PasswordtextBox.Text == "")
            {
                MessageBox.Show("Enter Password..");
            }
            else
            {
                if (dt.Rows.Count == 1)
                {
                    //red_adminid = idinputa.Text;
                    this.Hide();
                    HomePage av = new HomePage();
                    av.Show();
                }
                else
                {

                    MessageBox.Show("Invalid Username and Password!!");
                }
            }
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }


    }
}
