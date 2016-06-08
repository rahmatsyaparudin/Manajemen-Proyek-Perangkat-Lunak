using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace ProgramRentalPS
{
    public partial class FormPembayaranPersonal : Form
    {
        
        public FormPembayaranPersonal()
        {
            InitializeComponent();
            
            Fillcombo();
        }
        private void munculpanelMotor()
        {
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            comboId.Enabled = true;
            textNama.Enabled = true;
        }
        void Fillcombo()
        {
            string select = "SELECT id_user FROM TDaftaruser";
            SqlConnection con = koneksi.getKoneksi();
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string sId = dr["id_user"].ToString();
                    comboId.Items.Add(sId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal karena " + ex.Message);
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelsatu.Enabled = true;
            munculpanelMotor();
            Fillcombo();
        }

        private void comboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = "SELECT nama,alamat,jenis_sewa,waktu_masuk,notv FROM TDaftaruser WHERE id_user  = " + comboId.Text + "";
            SqlConnection con = koneksi.getKoneksi();
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader dr;

            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string sNama = dr["nama"].ToString();
                textNama.Text = sNama;
                string sAlamat = dr["alamat"].ToString();
                textAlamat.Text = sAlamat;
                string sjenis = dr["jenis_sewa"].ToString();
                textJenisSewa.Text = sjenis;
                string swaktu = dr["waktu_masuk"].ToString();
                textWaktuMasuk.Text = swaktu;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DateTime masuk = Convert.ToDateTime(textWaktuMasuk.Text);
            DateTime keluar = Convert.ToDateTime(textWaktuSelesai.Text);
            TimeSpan ts = new TimeSpan();
            ts = keluar.Subtract(masuk);
            textTotalWaktu.Text = ts.Hours+"";

            int waktu = Convert.ToInt32(textTotalWaktu.Text);
            if (textJenisSewa.Text == "Personal")
            {
                int total = (waktu) * 5000;
                textTotalBiaya.Text = Convert.ToString("Rp."+total);
            }
            else
            {
                int total = (waktu) * 4000;
                textTotalBiaya.Text = Convert.ToString("Rp." + total);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.getKoneksi();
            string nama = textNama.Text;
            string alamat = textAlamat.Text;
            string jenis_sewa = textJenisSewa.Text;
            string totwak = textTotalWaktu.Text;
            string totbiaya = textTotalBiaya.Text;

            using (conn)
            {
                conn.Open();

                string insert = "INSERT INTO TBayarpersonal (nama, alamat, jenis_sewa, total_waktu, biaya) values (@nama, @alamat, @jenis_sewa, @totwak, @totbiaya)";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@jenis_sewa", jenis_sewa);
                cmd.Parameters.AddWithValue("@totwak", totwak);
                cmd.Parameters.AddWithValue("@totbiaya", totbiaya);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Menambah Data");
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Data User");
                }

                conn.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            string strDate = dt.ToString("HH:mm:ss");

            textWaktuSelesai.Text = strDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
