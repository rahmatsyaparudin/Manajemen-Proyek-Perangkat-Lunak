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
    public partial class FormKeterangan : Form
    {
        private string strConnection = ConfigurationManager.ConnectionStrings["DbRentalConnectionString"].ConnectionString;

        public FormKeterangan()
        {
            InitializeComponent();
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand com = con.CreateCommand();

                com.CommandText = "SELECT * FROM TDaftarmember";
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "nama");
                dataGridDb.DataSource = ds;
                dataGridDb.DataMember = "nama";
                con.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand com = con.CreateCommand();

                com.CommandText = "SELECT * FROM TDaftaruser";
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "nama");
                dataGridDb.DataSource = ds;
                dataGridDb.DataMember = "nama";
                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand com = con.CreateCommand();

                com.CommandText = "SELECT * FROM TBayarpersonal";
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "nama");
                dataGridDb.DataSource = ds;
                dataGridDb.DataMember = "nama";
                con.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnection);

            using (conn)
            {
                conn.Open();

                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand com = con.CreateCommand();

                com.CommandText = "SELECT * FROM TBayarmember";
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "nama");
                dataGridDb.DataSource = ds;
                dataGridDb.DataMember = "nama";
                con.Close();
            }

        }     
    }
}
