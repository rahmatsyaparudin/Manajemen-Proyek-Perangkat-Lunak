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
    public partial class FormReportPembayaranMember : Form
    {
        public FormReportPembayaranMember()
        {
            InitializeComponent();
        }

        private void FormReportPembayaranMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbRentalDataSet3.TBayarmember' table. You can move, or remove it, as needed.
            this.TBayarmemberTableAdapter.Fill(this.DbRentalDataSet3.TBayarmember);

            this.reportViewer1.RefreshReport();
        }
    }
}
