﻿namespace AplikasiSelamatDatang
{
    partial class frmSelamatDatang
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
            this.btnKeterangan1 = new System.Windows.Forms.Button();
            this.btnKeterangan2 = new System.Windows.Forms.Button();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKeterangan1
            // 
            this.btnKeterangan1.Location = new System.Drawing.Point(16, 111);
            this.btnKeterangan1.Name = "btnKeterangan1";
            this.btnKeterangan1.Size = new System.Drawing.Size(83, 24);
            this.btnKeterangan1.TabIndex = 3;
            this.btnKeterangan1.Text = "Keterangan 1";
            this.btnKeterangan1.UseVisualStyleBackColor = true;
            this.btnKeterangan1.Click += new System.EventHandler(this.btnKeterangan1_Click);
            // 
            // btnKeterangan2
            // 
            this.btnKeterangan2.Location = new System.Drawing.Point(280, 112);
            this.btnKeterangan2.Name = "btnKeterangan2";
            this.btnKeterangan2.Size = new System.Drawing.Size(84, 23);
            this.btnKeterangan2.TabIndex = 5;
            this.btnKeterangan2.Text = "Keterangan 2";
            this.btnKeterangan2.UseVisualStyleBackColor = true;
            this.btnKeterangan2.Click += new System.EventHandler(this.btnKeterangan2_Click);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan.Location = new System.Drawing.Point(12, 39);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(301, 20);
            this.lblKeterangan.TabIndex = 6;
            this.lblKeterangan.Text = "Selamat Datang di Pemrograman C#";
            this.lblKeterangan.Click += new System.EventHandler(this.lblKeterangan_Click);
            // 
            // frmSelamatDatang
            // 
            this.ClientSize = new System.Drawing.Size(376, 173);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.btnKeterangan2);
            this.Controls.Add(this.btnKeterangan1);
            this.Name = "frmSelamatDatang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Selamat Datang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnKeterangan1;
        private System.Windows.Forms.Button btnKeterangan2;
        private System.Windows.Forms.Label lblKeterangan;
    }
}

