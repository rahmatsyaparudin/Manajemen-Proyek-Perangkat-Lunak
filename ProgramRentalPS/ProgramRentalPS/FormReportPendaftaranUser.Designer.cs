namespace ProgramRentalPS
{
    partial class FormReportPendaftaranUser
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TDaftaruserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbRentalDataSet1 = new ProgramRentalPS.DbRentalDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TDaftaruserTableAdapter = new ProgramRentalPS.DbRentalDataSet1TableAdapters.TDaftaruserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TDaftaruserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TDaftaruserBindingSource
            // 
            this.TDaftaruserBindingSource.DataMember = "TDaftaruser";
            this.TDaftaruserBindingSource.DataSource = this.DbRentalDataSet1;
            this.TDaftaruserBindingSource.CurrentChanged += new System.EventHandler(this.TDaftaruserBindingSource_CurrentChanged);
            // 
            // DbRentalDataSet1
            // 
            this.DbRentalDataSet1.DataSetName = "DbRentalDataSet1";
            this.DbRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TDaftaruserBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramRentalPS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(577, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // TDaftaruserTableAdapter
            // 
            this.TDaftaruserTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(175, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "USER PERSONAL";
            // 
            // FormReportPendaftaranUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportPendaftaranUser";
            this.Text = "Form Report Pendaftaran User";
            this.Load += new System.EventHandler(this.FormReportPendaftaranUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDaftaruserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbRentalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TDaftaruserBindingSource;
        private DbRentalDataSet1 DbRentalDataSet1;
        private DbRentalDataSet1TableAdapters.TDaftaruserTableAdapter TDaftaruserTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}