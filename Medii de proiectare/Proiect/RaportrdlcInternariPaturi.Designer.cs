namespace Proiect
{
    partial class RaportrdlcInternariPaturi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaportrdlcInternariPaturi));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bazadedate = new Proiect.bazadedate();
            this.queryIntPatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryIntPatTableAdapter = new Proiect.bazadedateTableAdapters.QueryIntPatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryIntPatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "tabelPaturi";
            reportDataSource2.Value = this.queryIntPatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect.RaportInternariPaturi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // bazadedate
            // 
            this.bazadedate.DataSetName = "bazadedate";
            this.bazadedate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryIntPatBindingSource
            // 
            this.queryIntPatBindingSource.DataMember = "QueryIntPat";
            this.queryIntPatBindingSource.DataSource = this.bazadedate;
            // 
            // queryIntPatTableAdapter
            // 
            this.queryIntPatTableAdapter.ClearBeforeFill = true;
            // 
            // RaportrdlcInternariPaturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RaportrdlcInternariPaturi";
            this.Text = "RaportrdlcInternariPaturi";
            this.Load += new System.EventHandler(this.RaportrdlcInternariPaturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryIntPatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource queryIntPatBindingSource;
        private bazadedateTableAdapters.QueryIntPatTableAdapter queryIntPatTableAdapter;
    }
}