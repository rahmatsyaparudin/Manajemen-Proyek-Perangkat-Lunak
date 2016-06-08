namespace ProgramRentalPS
{
    partial class FormPendaftaranUserBiasa
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
            this.components = new System.ComponentModel.Container();
            this.textNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboJenisSewa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.textWaktuMasuk = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(184, 71);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(200, 20);
            this.textNama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(184, 97);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(200, 20);
            this.textAlamat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Sewa";
            // 
            // comboJenisSewa
            // 
            this.comboJenisSewa.FormattingEnabled = true;
            this.comboJenisSewa.Items.AddRange(new object[] {
            "Personal",
            "Paket"});
            this.comboJenisSewa.Location = new System.Drawing.Point(184, 123);
            this.comboJenisSewa.Name = "comboJenisSewa";
            this.comboJenisSewa.Size = new System.Drawing.Size(200, 21);
            this.comboJenisSewa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Waktu Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No TV";
            // 
            // comboTv
            // 
            this.comboTv.FormattingEnabled = true;
            this.comboTv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboTv.Location = new System.Drawing.Point(184, 176);
            this.comboTv.Name = "comboTv";
            this.comboTv.Size = new System.Drawing.Size(200, 21);
            this.comboTv.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(23, 245);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(492, 115);
            this.dataGridUser.TabIndex = 15;
            this.dataGridUser.SelectionChanged += new System.EventHandler(this.dataGridUser_SelectionChanged);
            // 
            // textWaktuMasuk
            // 
            this.textWaktuMasuk.Location = new System.Drawing.Point(187, 150);
            this.textWaktuMasuk.Name = "textWaktuMasuk";
            this.textWaktuMasuk.Size = new System.Drawing.Size(197, 20);
            this.textWaktuMasuk.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(359, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Hapus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(440, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Cari";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textCari
            // 
            this.textCari.Location = new System.Drawing.Point(23, 219);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(411, 20);
            this.textCari.TabIndex = 21;
            // 
            // FormPendaftaranUserBiasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(538, 401);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textWaktuMasuk);
            this.Controls.Add(this.dataGridUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboTv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboJenisSewa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label2);
            this.Name = "FormPendaftaranUserBiasa";
            this.Text = "Form Pendaftaran User";
            this.Load += new System.EventHandler(this.FormPendaftaranUserBiasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboJenisSewa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.TextBox textWaktuMasuk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textCari;
    }
}