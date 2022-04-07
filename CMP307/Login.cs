using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace CMP307
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string UNamee;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1802193;Persist Security Info=True;User ID=sql1802193;Password=YbQm7PZdye");
            SqlCommand cmd = new SqlCommand("select * from loginnn where username = '" + txtUname.Text + "' and password='" + txtPassword.Text + "' and usertype='" + cbUserType.SelectedItem.ToString() + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("you are logged in as a " + dt.Rows[0][3]);
                if (cbUserType.SelectedIndex == 0)
                {
                    regUser f = new regUser();
                    f.Show(); //user login
                    this.Hide();
                    global.GlobalUser = txtUname.Text;

                }
                else if (cbUserType.SelectedIndex == 1)
                {
                    adminUser ff = new adminUser();
                    ff.Show(); // admin login
                    this.Hide();
                    global.GlobalUser = txtUname.Text;
                }

            }
            else
            {
                MessageBox.Show("Sorry, an error has occurred logging in."); //when username + password + user type dont match database
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register ff = new register();
            ff.Show(); //register page
            this.Hide();
        }
    }
}
