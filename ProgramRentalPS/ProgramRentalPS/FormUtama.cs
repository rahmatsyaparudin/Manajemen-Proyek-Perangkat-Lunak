using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramRentalPS
{
    public partial class FormUtama : Form
    {
        private Form formLogin;
        private DateTime jamku;
        public FormUtama()
        {
            InitializeComponent();

        }

        private void FormUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Visible = false;
            formLogin.Visible = true;
        }

        private void daftarMemberToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormPendaftaranUserBiasa fpub = new FormPendaftaranUserBiasa();
            fpub.Show();
        }

        private void daftarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPendaftaranMember fpm = new FormPendaftaranMember();
            fpm.Show();
        }

        private void pembayaranPersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPembayaranPersonal fpp = new FormPembayaranPersonal();
            fpp.Show();
        }

        private void pembayaranMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembayaranMember fpm = new FormPembayaranMember();
            fpm.Show();
        }

        private void reportTransaksiPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportPembayaranPersonal frpp= new FormReportPembayaranPersonal();
            frpp.Show();
        }

        private void reportTransaksiMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportPembayaranMember frpm = new FormReportPembayaranMember();
            frpm.Show();
        }

        private void keteranganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeterangan k = new FormKeterangan();
            k.Show();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            jamku = DateTime.Now;
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            jamku = DateTime.Now;

            label1.Text = jamku.Hour.ToString();
            label2.Text = jamku.Minute.ToString();
            label3.Text = jamku.Second.ToString();

        }

        private void mainMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarMainMember fdmm = new FormDaftarMainMember();
            fdmm.Show();
        }

        private void rDUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportPendaftaranUser frpu = new FormReportPendaftaranUser();
            frpu.Show();
        }

        private void reportMemberBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportPendaftaranMember frpm = new FormReportPendaftaranMember();
            frpm.Show();
        }
    }
}
