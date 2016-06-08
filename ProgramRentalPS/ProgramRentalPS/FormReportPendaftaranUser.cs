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
    public partial class FormReportPendaftaranUser : Form
    {
        public FormReportPendaftaranUser()
        {
            InitializeComponent();
            refresh();
        }
        private void FormReportPendaftaranUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbRentalDataSet1.TDaftaruser' table. You can move, or remove it, as needed.
            this.TDaftaruserTableAdapter.Fill(this.DbRentalDataSet1.TDaftaruser);

            this.reportViewer1.RefreshReport();
        }
        private void refresh()
        {
            this.Refresh();
        }

        private void TDaftaruserBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }    
    }
}
