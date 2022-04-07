using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMP307
{
    public partial class software : Form
    {
        public software()
        {
            InitializeComponent();
        }

        void Grid()
        {
            connect con = new connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from software", con.Active());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAP Files (*.txt)|*.txt";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(sfd.FileName));

                string str = "";
                int row = dataGridView1.Rows.Count;
                int cell = dataGridView1.Rows[1].Cells.Count;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < cell; j++)
                    {
                        // if (dataGridView1.Rows[i].Cells[j].Value == null)
                        // {
                        //return directly
                        //return;
                        //or set a value for the empty data
                        //dataGridView1.Rows[i].Cells[j].Value = "null";
                        // }
                        str += dataGridView1.Rows[i].Cells[j].Value.ToString() + ",";
                    }
                }
                write.WriteLine(str);

                write.Close();
                write.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect con = new connect();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[software] WHERE [ID] = '" + idD.Text + "'", con.Active());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successful. Hardware Item Erased.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    
