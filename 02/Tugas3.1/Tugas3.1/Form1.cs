using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._1
{
    public partial class frmTugas3Satu : Form
    {
        public frmTugas3Satu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label4.Text = "22.61.0233";
            label5.Text = "Muhammad Fabian Nurdin";
            label6.Text = "22BCI01";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
        }
    }
}
