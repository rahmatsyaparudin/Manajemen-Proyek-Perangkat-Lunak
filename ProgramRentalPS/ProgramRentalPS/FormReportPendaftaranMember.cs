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
    public partial class FormReportPendaftaranMember : Form
    {
        public FormReportPendaftaranMember()
        {
            InitializeComponent();
        }

        private void FormReportPendaftaranMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbRentalDataSet4.TDaftarmember' table. You can move, or remove it, as needed.
            this.TDaftarmemberTableAdapter.Fill(this.DbRentalDataSet4.TDaftarmember);

            this.reportViewer1.RefreshReport();
        }
    }
}
