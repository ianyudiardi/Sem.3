namespace Tugas3._3
{
    partial class frmTugas3Dua
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(161, 29);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(490, 26);
            this.txtNama.TabIndex = 0;
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(31, 306);
            this.txtPesan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(620, 26);
            this.txtPesan1.TabIndex = 1;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(31, 346);
            this.txtPesan2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(620, 26);
            this.txtPesan2.TabIndex = 2;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(31, 386);
            this.txtPesan3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(620, 26);
            this.txtPesan3.TabIndex = 3;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 20;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(163, 110);
            this.lstPekerjaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(488, 184);
            this.lstPekerjaan.TabIndex = 4;
            this.lstPekerjaan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 422);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(620, 35);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(161, 69);
            this.cmbPendidikan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(490, 28);
            this.cmbPendidikan.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pendidikan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pekerjaan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmTugas3Dua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.txtPesan1);
            this.Controls.Add(this.txtNama);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTugas3Dua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tugas 3.2 (Desain Menggunakan Komponen Layout)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

