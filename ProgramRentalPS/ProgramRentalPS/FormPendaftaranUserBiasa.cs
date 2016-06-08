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
    public partial class FormPendaftaranUserBiasa : Form
    {
        SqlConnection conn = koneksi.getKoneksi();
        private string id;
 
        public FormPendaftaranUserBiasa()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            textNama.Clear();
            textAlamat.Clear();
            textWaktuMasuk.Clear();
        }

        private void BindDatabase()
        {
            SqlConnection conn = koneksi.getKoneksi();

            using (conn)
            {
                conn.Open();

                string select = "SELECT * FROM TDaftaruser";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridUser.DataSource = table;
                dataGridUser.ClearSelection();

                ClearForm();
                conn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.getKoneksi();

            string nama = textNama.Text;
            string alamat = textAlamat.Text;
            string jenis_sewa = comboJenisSewa.Text;
            string waktu = textWaktuMasuk.Text;
            string notv = comboTv.Text;

            using (conn)
            {
                conn.Open();

                string insert = "INSERT INTO TDaftaruser (nama, alamat, jenis_sewa, notv, waktu_masuk) values (@nama, @alamat, @jenis, @notv, @waktu)";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@jenis", jenis_sewa);
                cmd.Parameters.AddWithValue("@notv", notv);
                cmd.Parameters.AddWithValue("@waktu", waktu);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Menambah Data User");
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Data User");
                }

                conn.Close();
                ClearForm();
                BindDatabase();
            }
        }

        private void FormPendaftaranUserBiasa_Load(object sender, EventArgs e)
        {
            BindDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            string strDate = dt.ToString("HH:mm:ss");

            textWaktuMasuk.Text = strDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text;
            string alamat = textAlamat.Text;
            string jenis_sewa = comboJenisSewa.Text;
            string waktu = textWaktuMasuk.Text;
            string notv = comboTv.Text;


            SqlConnection connection = koneksi.getKoneksi();
            using (connection)
            {
                connection.Open();

                string insert = "UPDATE TDaftaruser SET nama = @nama, alamat = @alamat, jenis_sewa = @jenis_sewa, notv = @notv, waktu_masuk = @waktu WHERE id_user = @idm";

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

        private void dataGridUser_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridUser.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                string nama = row.Cells[1].Value.ToString();
                string alamat = row.Cells[2].Value.ToString();
                string jenis_sewa = row.Cells[3].Value.ToString();
                string waktu = row.Cells[4].Value.ToString();
                string notv = row.Cells[5].Value.ToString();
                

                textNama.Text = nama;
                textAlamat.Text = alamat;
                comboJenisSewa.Text = jenis_sewa;
                textWaktuMasuk.Text = waktu;
                comboTv.Text = notv;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
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

                string insert = "DELETE FROM TDaftaruser WHERE id_user = @idu";

                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.AddWithValue("@idu", id);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Menghapus Data User");
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Data User");
                }

                connection.Close();
                BindDatabase();
            }
        }

        private void BindDatabase(string cari)
        {
            // buat koneksi
            SqlConnection conn = koneksi.getKoneksi();

            // gunakan using
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (cari != null)
                {
                    cmd.CommandText = "SELECT * FROM TDaftaruser WHERE nama LIKE @nama";
                    cmd.Parameters.AddWithValue("@nama", cari + "%");
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM TDaftaruser";
                }

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridUser.DataSource = table;

                reader.Close();
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string keyword = textCari.Text;
            BindDatabase(keyword);
        }
    }
}
