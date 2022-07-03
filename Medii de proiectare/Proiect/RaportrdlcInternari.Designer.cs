namespace Proiect
{
    partial class RaportrdlcInternari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaportrdlcInternari));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bazadedate = new Proiect.bazadedate();
            this.internariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internariTableAdapter = new Proiect.bazadedateTableAdapters.InternariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.internariBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect.RaportInternari.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(576, 342);
            this.reportViewer1.TabIndex = 0;
            // 
            // bazadedate
            // 
            this.bazadedate.DataSetName = "bazadedate";
            this.bazadedate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internariBindingSource
            // 
            this.internariBindingSource.DataMember = "Internari";
            this.internariBindingSource.DataSource = this.bazadedate;
            // 
            // internariTableAdapter
            // 
            this.internariTableAdapter.ClearBeforeFill = true;
            // 
            // RaportrdlcInternari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RaportrdlcInternari";
            this.Text = "RaportrdlcInternari";
            this.Load += new System.EventHandler(this.RaportrdlcInternari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource internariBindingSource;
        private bazadedateTableAdapters.InternariTableAdapter internariTableAdapter;
    }
}