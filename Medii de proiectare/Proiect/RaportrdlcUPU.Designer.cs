namespace Proiect
{
    partial class RaportrdlcUPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaportrdlcUPU));
            this.queryUPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedate = new Proiect.bazadedate();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.queryUPUTableAdapter = new Proiect.bazadedateTableAdapters.QueryUPUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.queryUPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            this.SuspendLayout();
            // 
            // queryUPUBindingSource
            // 
            this.queryUPUBindingSource.DataMember = "QueryUPU";
            this.queryUPUBindingSource.DataSource = this.bazadedate;
            // 
            // bazadedate
            // 
            this.bazadedate.DataSetName = "bazadedate";
            this.bazadedate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RaportTabelUPU";
            reportDataSource1.Value = this.queryUPUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect.RaportUPU.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // queryUPUTableAdapter
            // 
            this.queryUPUTableAdapter.ClearBeforeFill = true;
            // 
            // RaportrdlcUPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RaportrdlcUPU";
            this.Text = "Raport UPU";
            this.Load += new System.EventHandler(this.RaportParasireUPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryUPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource queryUPUBindingSource;
        private bazadedateTableAdapters.QueryUPUTableAdapter queryUPUTableAdapter;
    }
}