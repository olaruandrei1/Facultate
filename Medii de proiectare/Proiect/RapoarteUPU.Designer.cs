namespace Proiect
{
    partial class RapoarteUPU
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapoarteUPU));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUrgentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decizieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedate = new Proiect.bazadedate();
            this.comboCod = new System.Windows.Forms.ComboBox();
            this.codUrgentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartCod = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.codUrgentaTableAdapter = new Proiect.bazadedateTableAdapters.CodUrgentaTableAdapter();
            this.btnRaport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primiriUrgențeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteUPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteInternăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pacientiTableAdapter = new Proiect.bazadedateTableAdapters.PacientiTableAdapter();
            this.queryUPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryUPUTableAdapter = new Proiect.bazadedateTableAdapters.QueryUPUTableAdapter();
            this.codUrgentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codUrgentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCod)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryUPUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacientDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.codUrgentaDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn,
            this.decizieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(199, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 509);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            this.idPacientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacientDataGridViewTextBoxColumn.Visible = false;
            this.idPacientDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // codUrgentaDataGridViewTextBoxColumn
            // 
            this.codUrgentaDataGridViewTextBoxColumn.DataPropertyName = "CodUrgenta";
            this.codUrgentaDataGridViewTextBoxColumn.HeaderText = "CodUrgenta";
            this.codUrgentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codUrgentaDataGridViewTextBoxColumn.Name = "codUrgentaDataGridViewTextBoxColumn";
            this.codUrgentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codUrgentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            this.diagnosticDataGridViewTextBoxColumn.ReadOnly = true;
            this.diagnosticDataGridViewTextBoxColumn.Width = 125;
            // 
            // decizieDataGridViewTextBoxColumn
            // 
            this.decizieDataGridViewTextBoxColumn.DataPropertyName = "Decizie";
            this.decizieDataGridViewTextBoxColumn.HeaderText = "Decizie";
            this.decizieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.decizieDataGridViewTextBoxColumn.Name = "decizieDataGridViewTextBoxColumn";
            this.decizieDataGridViewTextBoxColumn.ReadOnly = true;
            this.decizieDataGridViewTextBoxColumn.Width = 125;
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.bazadedate;
            // 
            // bazadedate
            // 
            this.bazadedate.DataSetName = "bazadedate";
            this.bazadedate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboCod
            // 
            this.comboCod.BackColor = System.Drawing.Color.IndianRed;
            this.comboCod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.codUrgentaBindingSource, "DCodUrgenta", true));
            this.comboCod.DataSource = this.codUrgentaBindingSource;
            this.comboCod.DisplayMember = "DCodUrgenta";
            this.comboCod.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCod.ForeColor = System.Drawing.Color.White;
            this.comboCod.FormattingEnabled = true;
            this.comboCod.Location = new System.Drawing.Point(12, 40);
            this.comboCod.Name = "comboCod";
            this.comboCod.Size = new System.Drawing.Size(181, 29);
            this.comboCod.TabIndex = 2;
            this.comboCod.ValueMember = "DCodUrgenta";
            this.comboCod.SelectedIndexChanged += new System.EventHandler(this.comboCod_SelectedIndexChanged);
            // 
            // codUrgentaBindingSource
            // 
            this.codUrgentaBindingSource.DataMember = "CodUrgenta";
            this.codUrgentaBindingSource.DataSource = this.bazadedate;
            // 
            // chartCod
            // 
            this.chartCod.BackColor = System.Drawing.Color.IndianRed;
            this.chartCod.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartCod.BorderlineColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "ChartArea1";
            this.chartCod.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCod.Legends.Add(legend1);
            this.chartCod.Location = new System.Drawing.Point(923, 244);
            this.chartCod.Name = "chartCod";
            this.chartCod.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCod.Series.Add(series1);
            this.chartCod.Size = new System.Drawing.Size(760, 305);
            this.chartCod.TabIndex = 4;
            this.chartCod.Text = "Situație coduri UPU";
            // 
            // codUrgentaTableAdapter
            // 
            this.codUrgentaTableAdapter.ClearBeforeFill = true;
            // 
            // btnRaport
            // 
            this.btnRaport.BackColor = System.Drawing.Color.IndianRed;
            this.btnRaport.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaport.ForeColor = System.Drawing.Color.White;
            this.btnRaport.Location = new System.Drawing.Point(829, 40);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(261, 42);
            this.btnRaport.TabIndex = 5;
            this.btnRaport.Text = "Realizează Raport";
            this.btnRaport.UseVisualStyleBackColor = false;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primiriUrgențeToolStripMenuItem,
            this.internăriToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1745, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primiriUrgențeToolStripMenuItem
            // 
            this.primiriUrgențeToolStripMenuItem.Name = "primiriUrgențeToolStripMenuItem";
            this.primiriUrgențeToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.primiriUrgențeToolStripMenuItem.Text = "Primiri Urgențe";
            this.primiriUrgențeToolStripMenuItem.Click += new System.EventHandler(this.primiriUrgențeToolStripMenuItem_Click);
            // 
            // internăriToolStripMenuItem
            // 
            this.internăriToolStripMenuItem.Name = "internăriToolStripMenuItem";
            this.internăriToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.internăriToolStripMenuItem.Text = "Internări";
            this.internăriToolStripMenuItem.Click += new System.EventHandler(this.internăriToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapoarteUPUToolStripMenuItem,
            this.rapoarteInternăriToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // rapoarteUPUToolStripMenuItem
            // 
            this.rapoarteUPUToolStripMenuItem.Name = "rapoarteUPUToolStripMenuItem";
            this.rapoarteUPUToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.rapoarteUPUToolStripMenuItem.Text = "Rapoarte UPU";
            // 
            // rapoarteInternăriToolStripMenuItem
            // 
            this.rapoarteInternăriToolStripMenuItem.Name = "rapoarteInternăriToolStripMenuItem";
            this.rapoarteInternăriToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.rapoarteInternăriToolStripMenuItem.Text = "Rapoarte Internări";
            this.rapoarteInternăriToolStripMenuItem.Click += new System.EventHandler(this.rapoarteInternăriToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(966, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sumar:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codUrgentaDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.queryUPUBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.Red;
            this.dataGridView2.Location = new System.Drawing.Point(1096, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(438, 198);
            this.dataGridView2.TabIndex = 12;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // queryUPUBindingSource
            // 
            this.queryUPUBindingSource.DataMember = "QueryUPU";
            this.queryUPUBindingSource.DataSource = this.bazadedate;
            // 
            // queryUPUTableAdapter
            // 
            this.queryUPUTableAdapter.ClearBeforeFill = true;
            // 
            // codUrgentaDataGridViewTextBoxColumn1
            // 
            this.codUrgentaDataGridViewTextBoxColumn1.DataPropertyName = "CodUrgenta";
            this.codUrgentaDataGridViewTextBoxColumn1.HeaderText = "CodUrgenta";
            this.codUrgentaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codUrgentaDataGridViewTextBoxColumn1.Name = "codUrgentaDataGridViewTextBoxColumn1";
            this.codUrgentaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TotalIntrari";
            this.dataGridViewTextBoxColumn1.HeaderText = "TotalIntrari";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // RapoarteUPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1745, 561);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.chartCod);
            this.Controls.Add(this.comboCod);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RapoarteUPU";
            this.Text = "Rapoarte Primiri Urgențe - UPU";
            this.Load += new System.EventHandler(this.RapoarteUPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codUrgentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCod)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryUPUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCod;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource codUrgentaBindingSource;
        private bazadedateTableAdapters.CodUrgentaTableAdapter codUrgentaTableAdapter;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primiriUrgențeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteUPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteInternăriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private bazadedateTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIntrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUrgentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decizieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource queryUPUBindingSource;
        private bazadedateTableAdapters.QueryUPUTableAdapter queryUPUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUrgentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}