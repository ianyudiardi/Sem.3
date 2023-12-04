namespace PerpustakaanAppMVC.View
{
    partial class FrmMahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCari = new Button();
            btnTambah = new Button();
            btnPerbaiki = new Button();
            btnHapus = new Button();
            btnSelesai = new Button();
            txtNama = new TextBox();
            lvwMahasiswa = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Cari Nama Mahasiswa";
            // 
            // btnCari
            // 
            btnCari.Location = new Point(676, 4);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(112, 34);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(12, 404);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnPerbaiki
            // 
            btnPerbaiki.Location = new Point(130, 404);
            btnPerbaiki.Name = "btnPerbaiki";
            btnPerbaiki.Size = new Size(112, 34);
            btnPerbaiki.TabIndex = 3;
            btnPerbaiki.Text = "Perbaiki";
            btnPerbaiki.UseVisualStyleBackColor = true;
            btnPerbaiki.Click += btnPerbaiki_Click_1;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(248, 404);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 4;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click_1;
            // 
            // btnSelesai
            // 
            btnSelesai.Location = new Point(676, 404);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(112, 34);
            btnSelesai.TabIndex = 5;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(203, 6);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(467, 31);
            txtNama.TabIndex = 6;
            // 
            // lvwMahasiswa
            // 
            lvwMahasiswa.Location = new Point(12, 43);
            lvwMahasiswa.Name = "lvwMahasiswa";
            lvwMahasiswa.Size = new Size(776, 355);
            lvwMahasiswa.TabIndex = 7;
            lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // FrmMahasiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvwMahasiswa);
            Controls.Add(txtNama);
            Controls.Add(btnSelesai);
            Controls.Add(btnHapus);
            Controls.Add(btnPerbaiki);
            Controls.Add(btnTambah);
            Controls.Add(btnCari);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmMahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Mahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCari;
        private Button btnTambah;
        private Button btnPerbaiki;
        private Button btnHapus;
        private Button btnSelesai;
        private TextBox txtNama;
        private ListView lvwMahasiswa;
    }
}