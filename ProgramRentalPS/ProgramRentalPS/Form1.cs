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
    public partial class FormLogin : Form
    {
        private string strConnection = ConfigurationManager.ConnectionStrings["DbRentalConnectionString"].ConnectionString;
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Login()
        {
            SqlConnection con = new SqlConnection(strConnection);

            using (con)
            {
                con.Open();
                DataSet ds = new DataSet();
                string username = textUser.Text.Trim();
                string password = textPass.Text.Trim();


                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAdmin where username ='" + username + "' and password ='" + password + "'", con);
                da.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    MessageBox.Show("Invalid Username & Password");
                }
                else
                {
                    MessageBox.Show("Login Admin Berhasil");
                    FormUtama fpp = new FormUtama();
                    fpp.Show();
                    this.Visible = false;
                }

                con.Close();
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
            textUser.Text = "";
            textPass.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textUser.ResetText();
            textPass.ResetText();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
