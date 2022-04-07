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
    public partial class hardware : Form
    {

        public hardware()
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

      //  public void WriteGridData(DataTable dt)

     //   {

      //      String line = "";

       //     StreamWriter sw = new StreamWriter("/backup");

     //       foreach (DataRow item in dt.Rows)
     //
      //      {

      //          line = item[0].ToString(), item[1].ToString()   //........and so on your columns indices + "\n";

     //           sw.Write(line);



     //       }

     //       sw.Dispose();



      //  }


        private void hardware_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql1802193DataSet.hardware' table. You can move, or remove it, as needed.
            //SqlConnection con = new SqlConnection("Data Source=tolmount.abertay.ac.uk;Initial Catalog=sql1802193;Persist Security Info=True;User ID=sql1802193;Password=YbQm7PZdye");
            //this.hardwareTableAdapter.Fill(this.sql1802193DataSet.hardware);
            Grid();

        }

        private void button1_Click(object sender, EventArgs e)
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


    }
}

