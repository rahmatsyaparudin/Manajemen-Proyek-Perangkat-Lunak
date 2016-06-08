namespace ProgramRentalPS
{
    partial class FormReportPembayaranPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBayarpersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbRentalDataSet2 = new ProgramRentalPS.DbRentalDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBayarpersonalTableAdapter = new ProgramRentalPS.DbRentalDataSet2TableAdapters.TBayarpersonalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBayarpersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // TBayarpersonalBindingSource
            // 
            this.TBayarpersonalBindingSource.DataMember = "TBayarpersonal";
            this.TBayarpersonalBindingSource.DataSource = this.DbRentalDataSet2;
            // 
            // DbRentalDataSet2
            // 
            this.DbRentalDataSet2.DataSetName = "DbRentalDataSet2";
            this.DbRentalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBayarpersonalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramRentalPS.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(480, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT PEMBAYARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(150, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "USER PERSONAL";
            // 
            // TBayarpersonalTableAdapter
            // 
            this.TBayarpersonalTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportPembayaranPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportPembayaranPersonal";
            this.Text = "Form Report Pembayaran Personal";
            this.Load += new System.EventHandler(this.FormReportPembayaranPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBayarpersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource TBayarpersonalBindingSource;
        private DbRentalDataSet2 DbRentalDataSet2;
        private DbRentalDataSet2TableAdapters.TBayarpersonalTableAdapter TBayarpersonalTableAdapter;
    }
}