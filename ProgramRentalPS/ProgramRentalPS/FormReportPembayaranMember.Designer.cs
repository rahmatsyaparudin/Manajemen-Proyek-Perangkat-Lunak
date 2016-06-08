namespace ProgramRentalPS
{
    partial class FormReportPembayaranMember
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
            this.TBayarmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbRentalDataSet3 = new ProgramRentalPS.DbRentalDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBayarmemberTableAdapter = new ProgramRentalPS.DbRentalDataSet3TableAdapters.TBayarmemberTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TBayarmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // TBayarmemberBindingSource
            // 
            this.TBayarmemberBindingSource.DataMember = "TBayarmember";
            this.TBayarmemberBindingSource.DataSource = this.DbRentalDataSet3;
            // 
            // DbRentalDataSet3
            // 
            this.DbRentalDataSet3.DataSetName = "DbRentalDataSet3";
            this.DbRentalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBayarmemberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramRentalPS.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(480, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBayarmemberTableAdapter
            // 
            this.TBayarmemberTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT PEMBAYARAN MEMBER";
            // 
            // FormReportPembayaranMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportPembayaranMember";
            this.Text = "Form Report Pembayaran Member";
            this.Load += new System.EventHandler(this.FormReportPembayaranMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBayarmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBayarmemberBindingSource;
        private DbRentalDataSet3 DbRentalDataSet3;
        private DbRentalDataSet3TableAdapters.TBayarmemberTableAdapter TBayarmemberTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}