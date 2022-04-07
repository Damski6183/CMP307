using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMP307
{
    public partial class usersoftware : Form
    {
        public usersoftware()
        {
            InitializeComponent();
        }
        void Grid()
        {
            connect con = new connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from softwaree", con.Active());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["id"].ToString(); //prints database to grid table to be viewed
                dataGridView1.Rows[n].Cells[1].Value = item["name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["type"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["description"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["version"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["developer"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["license"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["purchdate"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["hardwareid"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["notes"].ToString();
            }

        }


        private void usersoftware_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                //Decimal.TryParse(txtPrice.Text, out decimal result);
                connect con = new connect();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [dbo].[swvulnerabilitiess] (swid, reason, hwid) VALUES ('{swid.Text}', '{reason.Text}', '{hwid.Text}')", con.Active());
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully Added New Vulnerability report.", "insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred as there was an empty textbox.", "insert", MessageBoxButtons.OK);
            }
        }

        bool Validate() //validate is to make sure the user doesnt add new user with no fields filled in.
        {
            bool returnval = true;
            if (swid.Text.Length == 0)
            {
                returnval = false;
            }
            else if (reason.Text.Length == 0)
            {
                returnval = false;
            }
            else if (hwid.Text.Length == 0)
            {
                returnval = false;
            }
            return returnval;
        }
    }
}
