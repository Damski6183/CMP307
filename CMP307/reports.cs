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
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }
        void Grid()
        {
            connect con = new connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from hwvulnerabilitiess", con.Active());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["id"].ToString(); //prints database to grid table to be viewed
                dataGridView1.Rows[n].Cells[1].Value = item["hwid"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["reason"].ToString();
            }

        }
        void Grid1()
        {
            connect con = new connect();
            SqlDataAdapter sda = new SqlDataAdapter("select * from swvulnerabilitiess", con.Active());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["id"].ToString(); //prints database to grid table to be viewed
                dataGridView1.Rows[n].Cells[1].Value = item["swid"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["reason"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["hwid"].ToString();
            }

        }


        private void reports_Load(object sender, EventArgs e)
        {
            Grid();
            Grid1();
        }
    }
}
