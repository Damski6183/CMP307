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
    public partial class userhardware : Form
    {
        public userhardware()
        {
            InitializeComponent();
        }

        void Grid()
        {
            connect con = new connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from hardware", con.Active());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["id"].ToString(); //prints database to grid table to be viewed
                dataGridView1.Rows[n].Cells[1].Value = item["name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["type"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["description"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["model"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["manufacturer"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["mac"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["ip"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["location"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["purchasedate"].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item["warranty"].ToString();
                dataGridView1.Rows[n].Cells[11].Value = item["notes"].ToString();
            }

        }

        private void userhardware_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                //Decimal.TryParse(txtPrice.Text, out decimal result);
                connect con = new connect();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [dbo].[hwvulnerabilitiess] (hwid, reason) VALUES ('{hwid.Text}', '{reason.Text}')", con.Active());
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully Added New Vulnerability report.", "insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred as there was an empty textbox.", "insert", MessageBoxButtons.OK);
            }
        }
    }
}
