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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            software software = new software();
            this.Hide();
            software.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e) // add record to software table
        {
            if (Validate())
            {

                connect con = new connect();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [dbo].[softwaree] (name, type, description, version, developer, license, purchdate, hardwareid, notes) VALUES ('{nameN.Text}', '{typeN.Text}', '{descN.Text}', '{verN.Text}', '{devN.Text}', '{licN.Text}', '{purchN.Text}', '{hwidN.Text}', '{notesN.Text}')", con.Active());
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully Added New Hardware Item.", "insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred as there was an empty textbox.", "insert", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateE())
            {
                connect con = new connect();
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[software]
                SET [name] = '" + nameE.Text + "',[type] = '" + typeE.Text + "',[description] = '" + descE.Text + "', [version] = '" + versE.Text + "',  [developer] = '" + devE.Text + "', [license] = '" + purchE.Text + "', [purchdate] = '" + hwidE.Text + "', [hardwareid] = '" + notesE.Text + "', [notes] = '" + purchE.Text + "' WHERE [ID] ='" + idE.Text + "'", con.Active());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful update.", "Continue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred as there was an empty textbox.", "insert", MessageBoxButtons.OK);
            }
        }

        bool ValidateE() //validate is to make sure the user doesnt add new hardware with no fields filled in.
        {
            bool returnval = true;
            if (nameE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (typeE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (descE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (versE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (devE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (licE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (purchE.Text.Length == 0)
            {
                returnval = false;
            }
            else if (hwidE.Text.Length == 0)
            {
                returnval = false;
            }
            return returnval; //notes is not checked because notes can be left empty
        }

        bool Validate() //validate is to make sure the user doesnt add new hardware with no fields filled in.
        {
            bool returnval = true;
            if (nameN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (typeN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (descN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (verN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (devN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (licN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (purchN.Text.Length == 0)
            {
                returnval = false;
            }
            else if (hwidN.Text.Length == 0)
            {
                returnval = false;
            }
            return returnval; //notes is not checked because notes can be left empty
        }

        private void software_Load(object sender, EventArgs e)
        {
            Grid();
        }
    }
}
    
