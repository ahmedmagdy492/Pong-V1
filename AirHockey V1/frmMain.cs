using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey_V1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_name.Text))
            {
                Form1 form1 = new Form1(txt_name.Text);
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Please Enter your name");
            }
        }
    }
}
