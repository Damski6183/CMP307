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
    public partial class regUser : Form
    {
        public regUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userhardware userhardware = new userhardware();
            userhardware.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersoftware usersoftware = new usersoftware();
            usersoftware.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.ShowDialog();
        }
    }
}
