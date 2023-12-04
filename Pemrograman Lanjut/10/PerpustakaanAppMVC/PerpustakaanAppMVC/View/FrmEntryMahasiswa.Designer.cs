namespace PerpustakaanAppMVC.View
{
    partial class FrmEntryMahasiswa
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
            label2 = new Label();
            label3 = new Label();
            txtNpm = new TextBox();
            txtAngkatan = new TextBox();
            txtNama = new TextBox();
            btnSimpan = new Button();
            btnSelesai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "NPM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Angkatan";
            // 
            // txtNpm
            // 
            txtNpm.Location = new Point(106, 12);
            txtNpm.Name = "txtNpm";
            txtNpm.Size = new Size(150, 31);
            txtNpm.TabIndex = 3;
            // 
            // txtAngkatan
            // 
            txtAngkatan.Location = new Point(106, 86);
            txtAngkatan.Name = "txtAngkatan";
            txtAngkatan.Size = new Size(150, 31);
            txtAngkatan.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(106, 49);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(378, 31);
            txtNama.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(256, 168);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnSelesai
            // 
            btnSelesai.Location = new Point(374, 168);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(112, 34);
            btnSelesai.TabIndex = 7;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // FrmEntryMahasiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 214);
            Controls.Add(btnSelesai);
            Controls.Add(btnSimpan);
            Controls.Add(txtNama);
            Controls.Add(txtAngkatan);
            Controls.Add(txtNpm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEntryMahasiswa";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEntryMahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNpm;
        private TextBox txtAngkatan;
        private TextBox txtNama;
        private Button btnSimpan;
        private Button btnSelesai;
    }
}