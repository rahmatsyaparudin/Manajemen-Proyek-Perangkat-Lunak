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
    public partial class FormPembayaran : Form
    {
        private string strConnection = ConfigurationManager.ConnectionStrings["DbRentalConnectionString"].ConnectionString;
        private string id_member;

        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            textNama.Clear();
            textJenis.Clear();
            textTotal.Clear();
        }

        private void BindDatabase()
        {
            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                string select = "SELECT * FROM ttransaksi WHERE jenis_sewa = 'Personal'";
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridPembayaran.DataSource = table;
                dataGridPembayaran.ClearSelection();

                ClearForm();
                conn.Close();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["DbRentalConnectionString"].ConnectionString;
            string select = "SELECT nama FROM TMember WHERE id_member = " + comboBox1.Text + "";
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string sNama = dr["nama"].ToString();
                    textNama.Text = sNama;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal karena " + ex.Message);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            id_member = comboBox1.Text;
            string nama = textNama.Text;
            string jenis_sewa = textJenis.Text;
            string noTV = comboTv.Text;
            string waktu = comboWaktu.Text;
            string total = textTotal.Text;


            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                string insert = "INSERT INTO ttransaksi (nama, jenis_sewa, noTV, waktu, total) values (@nama, @jenis, @noTV, @waktu, @total)";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@id", id_member);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jenis", jenis_sewa);
                cmd.Parameters.AddWithValue("@noTV", noTV);
                cmd.Parameters.AddWithValue("@waktu", waktu);
                cmd.Parameters.AddWithValue("@total", total);

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

                BindDatabase();
            }
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            BindDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int waktu = Convert.ToInt32(comboWaktu.Text);
            int total = (waktu) * 5000;
            textTotal.Text = Convert.ToString(total);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text;
            string jenis_sewa = textJenis.Text;
            string noTV = comboTv.Text;
            string waktu = comboWaktu.Text;
            string total = textTotal.Text;


            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                string insert = "UPDATE ttransaksi SET nama = @nama, jenis_sewa = @jenis, noTV = @noTV, total = @total, waktu = @waktu WHERE id_member = @id";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@id", id_member);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@jenis", jenis_sewa);
                cmd.Parameters.AddWithValue("@noTV", noTV);
                cmd.Parameters.AddWithValue("@waktu", waktu);
                cmd.Parameters.AddWithValue("@total", total);

                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Mengubah Data User");
                }
                else
                {
                    MessageBox.Show("Gagal Mengubah Data User");
                }

                conn.Close();

                BindDatabase();
            }
        }

        private void dataGridPembayaran_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridPembayaran.SelectedRows)
            {
                id_member = row.Cells[0].Value.ToString(); ;
                string nama = row.Cells[1].Value.ToString();
                string jenis_sewa = row.Cells[2].Value.ToString();
                string noTV = row.Cells[3].Value.ToString();
                string waktu = row.Cells[4].Value.ToString();
                string total = row.Cells[5].Value.ToString();


                textNama.Text = nama;
                textJenis.Text = jenis_sewa;
                comboTv.Text = noTV;
                comboWaktu.Text = waktu;
                textTotal.Text = total;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text;
            string title = "Pesan Konfirmasi";
            string message = "Apakah Anda Yakin " + nama.Trim() + " Akan Dihapus?";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result != DialogResult.OK)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                string insert = "DELETE FROM ttransaksi WHERE id_member = @id";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@id", id_member);


                int insertResult = cmd.ExecuteNonQuery();

                if (insertResult == 1)
                {
                    MessageBox.Show("Sukses Menghapus Data Transaksi");
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Data Transaksi");
                }

                conn.Close();

                BindDatabase();
            }
        }

    }
}
