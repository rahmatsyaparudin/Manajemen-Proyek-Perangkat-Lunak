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
    public partial class FormReportPembayaranPersonal : Form
    {
        public FormReportPembayaranPersonal()
        {
            InitializeComponent();
        }

        private void FormReportPembayaranPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbRentalDataSet2.TBayarpersonal' table. You can move, or remove it, as needed.
            this.TBayarpersonalTableAdapter.Fill(this.DbRentalDataSet2.TBayarpersonal);

            this.reportViewer1.RefreshReport();
        }
    }
}
