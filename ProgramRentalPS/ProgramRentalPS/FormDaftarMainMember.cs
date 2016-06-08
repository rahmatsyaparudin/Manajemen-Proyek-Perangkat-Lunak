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
    public partial class FormDaftarMainMember : Form
    {
        private string id;
        public FormDaftarMainMember()
        {
            InitializeComponent();
            Fillcombo();
        }

        private void BindDatabase()
        {
            SqlConnection conn = koneksi.getKoneksi();

            using (conn)
            {
                conn.Open();

                string select = "SELECT * FROM TMainmember";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridMember.DataSource = table;
                dataGridMember.ClearSelection();

                conn.Close();
            }
        }
        void Fillcombo()
        {
            string select = "SELECT id_member FROM TDaftarmember";
            SqlConnection con = koneksi.getKoneksi();
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string sId = dr["id_member"].ToString();
                    comboIdMember.Items.Add(sId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal karena " + ex.Message);
                Application.Exit();
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = "SELECT nama,alamat FROM TDaftarmember WHERE id_member  = " + comboIdMember.Text + "";
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.getKoneksi();
            string nama = textNama.Text;
            string alamat = textAlamat.Text;
            string jenis_sewa = comboJenisSewa.Text;
            string waktu = textWaktuMasuk.Text;
            string noTv = comboTv.Text;

            using (conn)
            {
                conn.Open();

                string insert = "INSERT INTO TMainmember (nama, alamat, jenis_sewa, waktu_masuk, notv) values (@nama, @alamat, @jenis, @waktu, @noTV)";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@jenis", jenis_sewa);
                cmd.Parameters.AddWithValue("@waktu", waktu);
                cmd.Parameters.AddWithValue("@noTV", noTv);


                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Menambah Data Member");
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Data Member");
                }

                conn.Close();

                BindDatabase();
            }
        }

        private void FormDaftarMainMember_Load(object sender, EventArgs e)
        {
            BindDatabase();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            string strDate = dt.ToString("HH:mm:ss");

            textWaktuMasuk.Text = strDate;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridMember_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridMember.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string nama = row.Cells[1].Value.ToString();
                string alamat = row.Cells[2].Value.ToString();
                string jenis_sewa = row.Cells[3].Value.ToString();
                string waktu = row.Cells[4].Value.ToString();
                string notv = row.Cells[5].Value.ToString();
                

                comboIdMember.Text = id;
                textNama.Text = nama;
                textAlamat.Text = alamat;
                comboJenisSewa.Text = jenis_sewa;
                comboTv.Text = notv;
                textWaktuMasuk.Text = waktu;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = comboIdMember.Text;
            string nama = textNama.Text;
            string alamat = textAlamat.Text;
            string jenis_sewa = comboJenisSewa.Text;
            string waktu = textWaktuMasuk.Text;
            string notv = comboTv.Text;


            SqlConnection connection = koneksi.getKoneksi();
            using (connection)
            {
                connection.Open();

                string insert = "UPDATE TMainmember SET nama = @nama, alamat = @alamat, jenis_sewa = @jenis_sewa, notv = @notv, waktu_masuk = @waktu WHERE id_main = @idm";

                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.AddWithValue("@idm", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@jenis_sewa", jenis_sewa);
                cmd.Parameters.AddWithValue("@waktu", waktu);
                cmd.Parameters.AddWithValue("@notv", notv);
                

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Mengubah Data");
                }
                else
                {
                    MessageBox.Show("Gagal Mengubah Data");
                }

                connection.Close();

                BindDatabase();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string idm = comboIdMember.Text;
            string nama = textNama.Text;
            string title = "Pesan Konfirmasi";
            string message = "Anda yakin " + nama.Trim() + " akan dihapus ?";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result != DialogResult.OK)
            {
                return;
            }

            SqlConnection connection = koneksi.getKoneksi();
            using (connection)
            {
                connection.Open();

                string insert = "DELETE FROM TMainmember WHERE id_main = @idm";

                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.AddWithValue("@idm", idm);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Menghapus Data Member");
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Data Member");
                }

                connection.Close();
                BindDatabase();
            }
        }
    }
}
