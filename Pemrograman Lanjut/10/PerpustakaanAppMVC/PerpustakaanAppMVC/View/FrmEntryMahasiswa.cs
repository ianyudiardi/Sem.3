using PerpustakaanAppMVC.Controller;
using PerpustakaanAppMVC.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanAppMVC.View
{
    public partial class FrmEntryMahasiswa : Form
    {
        //deklarasi tipe ata untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Mahasiswa mhs);

        //deklarasi event ketika terjadi input data baru
        public event CreateUpdateEventHandler OnCreate;

        //deklarasi event ketika terjadi update data
        public event CreateUpdateEventHandler OnUpdate;

        //deklarasi objek controller
        private MahasiswaController controller;

        //deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek mahasiswa
        private Mahasiswa mhs;

        //constructor default
        public FrmEntryMahasiswa()
        {
            InitializeComponent();
        }

        //constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryMahasiswa(string title, MahasiswaController controller) : this()
        {
            //ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        //constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryMahasiswa(string title, Mahasiswa obj, MahasiswaController controller) : this()
        {
            //ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; //set status edit data
            mhs = obj; //set objek mhs yg akan diedit

            //untuk edit data, tampilkan data lama
            txtNpm.Text = mhs.Npm;
            txtNama.Text = mhs.Nama;
            txtAngkatan.Text = mhs.Angkatan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //jika data baru, inisialisasi objek mahasiswa
            if (isNewData) mhs = new Mahasiswa();

            //set nilai property mahasiswa yang diambil dari textbox
            mhs.Npm = txtNpm.Text;
            mhs.Nama = txtNama.Text;
            mhs.Angkatan = txtAngkatan.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil Create
            {
                result = controller.Create(mhs);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(mhs);
                    txtNpm.Clear();
                    txtNama.Clear();
                    txtAngkatan.Clear();

                    txtNpm.Focus();
                }
            }
            else //edit data, panggil method update
            {
                result = controller.Update(mhs);

                if (result > 0)
                {
                    OnUpdate(mhs);
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
