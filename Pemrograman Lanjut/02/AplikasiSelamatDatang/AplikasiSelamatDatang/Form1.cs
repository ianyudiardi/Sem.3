﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiSelamatDatang
{
    public partial class frmSelamatDatang : Form
    {
        public frmSelamatDatang()
        {
            InitializeComponent();
        }

        private void btnKeterangan1_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Selamat Datang di Pemrograman C#";
        }

        private void btnKeterangan2_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Begitu Mudahnya Membuat Aplikasi Berbasis Windows";
        }

        private void lblKeterangan_Click(object sender, EventArgs e)
        {

        }
    }       
}
