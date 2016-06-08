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
    public partial class FormPendaftaranMember : Form
    {
        SqlConnection conn = koneksi.getKoneksi();
        private string id;
        public FormPendaftaranMember()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            textNama.Clear();
            textAlamat.Clear();
        }
         private void BindDatabase()
        {
            SqlConnection conn = koneksi.getKoneksi();

            using (conn)
            {
                conn.Open();

                string select = "SELECT * FROM TDaftarmember";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridMember.DataSource = table;
                dataGridMember.ClearSelection();

                ClearForm();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text;
            string nope = textTelp.Text;
            string alamat = textAlamat.Text;
            string jenis = comboJenisMember.Text;
            string tanggal = textTanggalDaftar.Text;

            using (conn)
            {
                conn.Open();

                string insert = "INSERT INTO TDaftarmember (nama, alamat, nope, tanggal_daftar, jenis_member) values (@nama, @alamat, @nope, @tanggal, @jenis)";
                SqlCommand cmd = new SqlCommand(insert, conn);


                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@nope", nope);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@jenis", jenis);


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

        private void FormPendaftaranMember_Load(object sender, EventArgs e)
        {
            BindDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTanggalDaftar.Value;

            string strDate = dt.ToString("dd MMMM yyyy");

            textTanggalDaftar.Text = strDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text;
            string alamat = textAlamat.Text;
            string nope = textTelp.Text;
            string tgl = textTanggalDaftar.Text;
            string jenis = comboJenisMember.Text;
            


            SqlConnection connection = koneksi.getKoneksi();
            using (connection)
            {
                connection.Open();

                string insert = "UPDATE TDaftarmember SET nama = @nama, alamat = @alamat, nope = @nope, tanggal_daftar = @tanggal_daftar, jenis_member = @jenis_member WHERE id_member = @idm";

                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.AddWithValue("@idm", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@nope", nope);
                cmd.Parameters.AddWithValue("@tanggal_daftar", tgl);
                cmd.Parameters.AddWithValue("@jenis_member", jenis);

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

        private void dataGridMember_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridMember.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                string nama = row.Cells[1].Value.ToString();
                string alamat = row.Cells[2].Value.ToString();
                string nope = row.Cells[3].Value.ToString();
                string tgl = row.Cells[4].Value.ToString();
                string jenis = row.Cells[5].Value.ToString();

                textNama.Text = nama;
                textAlamat.Text = alamat;
                textTelp.Text = nope;
                textTanggalDaftar.Text = tgl;
                comboJenisMember.Text = jenis;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

                string insert = "DELETE FROM TDaftarmember WHERE id_member = @idm";

                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.AddWithValue("@idm", id);

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
