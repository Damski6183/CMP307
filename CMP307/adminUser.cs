using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMP307
{
    public partial class adminUser : Form
    {
        public adminUser()
        {
            InitializeComponent();
        }

        private void adminUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hardware f = new hardware();
            f.ShowDialog(); // Shows hardware form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            software f = new software();
            f.ShowDialog(); // Shows software form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.ShowDialog();
        }
    }
}
