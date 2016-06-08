namespace ProgramRentalPS
{
    partial class FormDaftarMainMember
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboTv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboJenisSewa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboIdMember = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textWaktuMasuk = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textCari = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "ID Member";
            // 
            // dataGridMember
            // 
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Location = new System.Drawing.Point(25, 226);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.Size = new System.Drawing.Size(530, 116);
            this.dataGridMember.TabIndex = 32;
            this.dataGridMember.SelectionChanged += new System.EventHandler(this.dataGridMember_SelectionChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboTv.Location = new System.Drawing.Point(205, 151);
            this.comboTv.Name = "comboTv";
            this.comboTv.Size = new System.Drawing.Size(200, 21);
            this.comboTv.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "No TV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Waktu Masuk";
            // 
            // comboJenisSewa
            // 
            this.comboJenisSewa.FormattingEnabled = true;
            this.comboJenisSewa.Items.AddRange(new object[] {
            "Personal",
            "Paket"});
            this.comboJenisSewa.Location = new System.Drawing.Point(205, 98);
            this.comboJenisSewa.Name = "comboJenisSewa";
            this.comboJenisSewa.Size = new System.Drawing.Size(200, 21);
            this.comboJenisSewa.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Jenis Sewa";
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(205, 72);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(200, 20);
            this.textAlamat.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alamat";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(205, 46);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(200, 20);
            this.textNama.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama";
            // 
            // comboIdMember
            // 
            this.comboIdMember.FormattingEnabled = true;
            this.comboIdMember.Location = new System.Drawing.Point(205, 19);
            this.comboIdMember.Name = "comboIdMember";
            this.comboIdMember.Size = new System.Drawing.Size(200, 21);
            this.comboIdMember.TabIndex = 34;
            this.comboIdMember.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textWaktuMasuk
            // 
            this.textWaktuMasuk.Location = new System.Drawing.Point(205, 124);
            this.textWaktuMasuk.Name = "textWaktuMasuk";
            this.textWaktuMasuk.Size = new System.Drawing.Size(200, 20);
            this.textWaktuMasuk.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Hapus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textCari
            // 
            this.textCari.Location = new System.Drawing.Point(25, 200);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(449, 20);
            this.textCari.TabIndex = 40;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(480, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "Cari";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormDaftarMainMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 385);
            this.Controls.Add(this.textCari);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textWaktuMasuk);
            this.Controls.Add(this.comboIdMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridMember);
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
            this.Name = "FormDaftarMainMember";
            this.Text = "Form Main Member";
            this.Load += new System.EventHandler(this.FormDaftarMainMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboTv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboJenisSewa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboIdMember;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textWaktuMasuk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textCari;
        private System.Windows.Forms.Button button6;
    }
}