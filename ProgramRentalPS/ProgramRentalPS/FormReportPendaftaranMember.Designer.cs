namespace ProgramRentalPS
{
    partial class FormReportPendaftaranMember
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
            this.TDaftarmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbRentalDataSet4 = new ProgramRentalPS.DbRentalDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.TDaftarmemberTableAdapter = new ProgramRentalPS.DbRentalDataSet4TableAdapters.TDaftarmemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TDaftarmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // TDaftarmemberBindingSource
            // 
            this.TDaftarmemberBindingSource.DataMember = "TDaftarmember";
            this.TDaftarmemberBindingSource.DataSource = this.DbRentalDataSet4;
            // 
            // DbRentalDataSet4
            // 
            this.DbRentalDataSet4.DataSetName = "DbRentalDataSet4";
            this.DbRentalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TDaftarmemberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramRentalPS.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(445, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "PENDAFTARAN MEMBER";
            // 
            // TDaftarmemberTableAdapter
            // 
            this.TDaftarmemberTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportPendaftaranMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportPendaftaranMember";
            this.Text = "Form Report Pendaftaran Member";
            this.Load += new System.EventHandler(this.FormReportPendaftaranMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDaftarmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource TDaftarmemberBindingSource;
        private DbRentalDataSet4 DbRentalDataSet4;
        private DbRentalDataSet4TableAdapters.TDaftarmemberTableAdapter TDaftarmemberTableAdapter;
    }
}