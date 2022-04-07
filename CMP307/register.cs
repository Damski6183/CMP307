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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                SqlConnection con = new SqlConnection("Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1802193;Persist Security Info=True;User ID=sql1802193;Password=YbQm7PZdye");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[loginnn]
                 ([username]
                 ,[password]
                 ,[usertype])
                  VALUES
                 ('" + txtUname.Text + "', '" + txtPw.Text + "', '" + cbUT.SelectedItem.ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Complete.");
                Login f = new Login();
                f.Show(); //back to login panel
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration incomplete due to error. Please try again.");
            }
        }

        bool Validate() //validate is to make sure the user doesnt add new user with no fields filled in.
        {
            bool returnval = true;
            if (txtUname.Text.Length == 0)
            {
                returnval = false;
            }
            else if (txtPw.Text.Length == 0)
            {
                returnval = false;
            }
            else if (cbUT.Text.Length == 0)
            {
                returnval = false;
            }
            return returnval;

        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
