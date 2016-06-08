namespace ProgramRentalPS
{
    partial class FormPendaftaranMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTanggalDaftar = new System.Windows.Forms.DateTimePicker();
            this.comboJenisMember = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.textTanggalDaftar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textTelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(213, 49);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(200, 20);
            this.textNama.TabIndex = 1;
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(213, 75);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(200, 20);
            this.textAlamat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal Daftar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Member";
            // 
            // dateTanggalDaftar
            // 
            this.dateTanggalDaftar.Location = new System.Drawing.Point(213, 161);
            this.dateTanggalDaftar.Name = "dateTanggalDaftar";
            this.dateTanggalDaftar.Size = new System.Drawing.Size(200, 20);
            this.dateTanggalDaftar.TabIndex = 7;
            // 
            // comboJenisMember
            // 
            this.comboJenisMember.FormattingEnabled = true;
            this.comboJenisMember.Items.AddRange(new object[] {
            "1 Bulan",
            "1 Tahun"});
            this.comboJenisMember.Location = new System.Drawing.Point(213, 134);
            this.comboJenisMember.Name = "comboJenisMember";
            this.comboJenisMember.Size = new System.Drawing.Size(200, 21);
            this.comboJenisMember.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridMember
            // 
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Location = new System.Drawing.Point(12, 244);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.Size = new System.Drawing.Size(538, 118);
            this.dataGridMember.TabIndex = 11;
            this.dataGridMember.SelectionChanged += new System.EventHandler(this.dataGridMember_SelectionChanged);
            // 
            // textTanggalDaftar
            // 
            this.textTanggalDaftar.Location = new System.Drawing.Point(213, 189);
            this.textTanggalDaftar.Name = "textTanggalDaftar";
            this.textTanggalDaftar.Size = new System.Drawing.Size(200, 20);
            this.textTanggalDaftar.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textTelp
            // 
            this.textTelp.Location = new System.Drawing.Point(213, 108);
            this.textTelp.Name = "textTelp";
            this.textTelp.Size = new System.Drawing.Size(200, 20);
            this.textTelp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telp";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Ubah";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(475, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Cari";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textCari
            // 
            this.textCari.Location = new System.Drawing.Point(12, 215);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(457, 20);
            this.textCari.TabIndex = 19;
            // 
            // FormPendaftaranMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 400);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textTelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textTanggalDaftar);
            this.Controls.Add(this.dataGridMember);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboJenisMember);
            this.Controls.Add(this.dateTanggalDaftar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAlamat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label1);
            this.Name = "FormPendaftaranMember";
            this.Text = "Form Pendaftaran Member";
            this.Load += new System.EventHandler(this.FormPendaftaranMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTanggalDaftar;
        private System.Windows.Forms.ComboBox comboJenisMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.TextBox textTanggalDaftar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textTelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textCari;
    }
}