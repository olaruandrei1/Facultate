namespace Proiect
{
    partial class RapoarteInternari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapoarteInternari));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primiriUrgențeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteUPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteInternăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sectiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedate = new Proiect.bazadedate();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInternareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInternariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExternariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epicrizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozaCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartPat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnRaport = new System.Windows.Forms.Button();
            this.lblDI = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.sectiiTableAdapter = new Proiect.bazadedateTableAdapters.SectiiTableAdapter();
            this.internariTableAdapter = new Proiect.bazadedateTableAdapters.InternariTableAdapter();
            this.queryIntPatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRaportPaturi = new System.Windows.Forms.Button();
            this.btnFiltruData = new System.Windows.Forms.Button();
            this.internariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numarActualPaturiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.queryIntPatTableAdapter = new Proiect.bazadedateTableAdapters.QueryIntPatTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numePacientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectieDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInternariiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExternariiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInternareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internariDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internariDataTableAdapter = new Proiect.bazadedateTableAdapters.InternariDataTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryIntPatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primiriUrgențeToolStripMenuItem,
            this.internăriToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1144, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primiriUrgențeToolStripMenuItem
            // 
            this.primiriUrgențeToolStripMenuItem.Name = "primiriUrgențeToolStripMenuItem";
            this.primiriUrgențeToolStripMenuItem.Size = new System.Drawing.Size(109, 21);
            this.primiriUrgențeToolStripMenuItem.Text = "Primiri Urgențe";
            this.primiriUrgențeToolStripMenuItem.Click += new System.EventHandler(this.primiriUrgențeToolStripMenuItem_Click_1);
            // 
            // internăriToolStripMenuItem
            // 
            this.internăriToolStripMenuItem.Name = "internăriToolStripMenuItem";
            this.internăriToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.internăriToolStripMenuItem.Text = "Internări";
            this.internăriToolStripMenuItem.Click += new System.EventHandler(this.internăriToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapoarteUPUToolStripMenuItem,
            this.rapoarteInternăriToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // rapoarteUPUToolStripMenuItem
            // 
            this.rapoarteUPUToolStripMenuItem.Name = "rapoarteUPUToolStripMenuItem";
            this.rapoarteUPUToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rapoarteUPUToolStripMenuItem.Text = "Rapoarte UPU";
            this.rapoarteUPUToolStripMenuItem.Click += new System.EventHandler(this.rapoarteUPUToolStripMenuItem_Click);
            // 
            // rapoarteInternăriToolStripMenuItem
            // 
            this.rapoarteInternăriToolStripMenuItem.Name = "rapoarteInternăriToolStripMenuItem";
            this.rapoarteInternăriToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rapoarteInternăriToolStripMenuItem.Text = "Rapoarte Internări";
            this.rapoarteInternăriToolStripMenuItem.Click += new System.EventHandler(this.rapoarteInternăriToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectiiBindingSource, "DSectie", true));
            this.comboBox1.DataSource = this.sectiiBindingSource;
            this.comboBox1.DisplayMember = "DSectie";
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 67);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "DSectie";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sectiiBindingSource
            // 
            this.sectiiBindingSource.DataMember = "Sectii";
            this.sectiiBindingSource.DataSource = this.bazadedate;
            // 
            // bazadedate
            // 
            this.bazadedate.DataSetName = "bazadedate";
            this.bazadedate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInternareDataGridViewTextBoxColumn,
            this.idPacientDataGridViewTextBoxColumn,
            this.numePacientDataGridViewTextBoxColumn,
            this.sectieDataGridViewTextBoxColumn,
            this.dataInternariiDataGridViewTextBoxColumn,
            this.dataExternariiDataGridViewTextBoxColumn,
            this.epicrizaDataGridViewTextBoxColumn,
            this.pozaCardDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.internariBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(197, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(349, 515);
            this.dataGridView1.TabIndex = 12;
            // 
            // idInternareDataGridViewTextBoxColumn
            // 
            this.idInternareDataGridViewTextBoxColumn.DataPropertyName = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn.HeaderText = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn.Name = "idInternareDataGridViewTextBoxColumn";
            this.idInternareDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            this.idPacientDataGridViewTextBoxColumn.Visible = false;
            // 
            // numePacientDataGridViewTextBoxColumn
            // 
            this.numePacientDataGridViewTextBoxColumn.DataPropertyName = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.HeaderText = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.Name = "numePacientDataGridViewTextBoxColumn";
            // 
            // sectieDataGridViewTextBoxColumn
            // 
            this.sectieDataGridViewTextBoxColumn.DataPropertyName = "Sectie";
            this.sectieDataGridViewTextBoxColumn.HeaderText = "Sectie";
            this.sectieDataGridViewTextBoxColumn.Name = "sectieDataGridViewTextBoxColumn";
            // 
            // dataInternariiDataGridViewTextBoxColumn
            // 
            this.dataInternariiDataGridViewTextBoxColumn.DataPropertyName = "DataInternarii";
            this.dataInternariiDataGridViewTextBoxColumn.HeaderText = "DataInternarii";
            this.dataInternariiDataGridViewTextBoxColumn.Name = "dataInternariiDataGridViewTextBoxColumn";
            this.dataInternariiDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataExternariiDataGridViewTextBoxColumn
            // 
            this.dataExternariiDataGridViewTextBoxColumn.DataPropertyName = "DataExternarii";
            this.dataExternariiDataGridViewTextBoxColumn.HeaderText = "DataExternarii";
            this.dataExternariiDataGridViewTextBoxColumn.Name = "dataExternariiDataGridViewTextBoxColumn";
            this.dataExternariiDataGridViewTextBoxColumn.Visible = false;
            // 
            // epicrizaDataGridViewTextBoxColumn
            // 
            this.epicrizaDataGridViewTextBoxColumn.DataPropertyName = "Epicriza";
            this.epicrizaDataGridViewTextBoxColumn.HeaderText = "Epicriza";
            this.epicrizaDataGridViewTextBoxColumn.Name = "epicrizaDataGridViewTextBoxColumn";
            // 
            // pozaCardDataGridViewTextBoxColumn
            // 
            this.pozaCardDataGridViewTextBoxColumn.DataPropertyName = "PozaCard";
            this.pozaCardDataGridViewTextBoxColumn.HeaderText = "PozaCard";
            this.pozaCardDataGridViewTextBoxColumn.Name = "pozaCardDataGridViewTextBoxColumn";
            this.pozaCardDataGridViewTextBoxColumn.Visible = false;
            // 
            // internariBindingSource1
            // 
            this.internariBindingSource1.DataMember = "Internari";
            this.internariBindingSource1.DataSource = this.bazadedateBindingSource;
            // 
            // bazadedateBindingSource
            // 
            this.bazadedateBindingSource.DataSource = this.bazadedate;
            this.bazadedateBindingSource.Position = 0;
            // 
            // chartPat
            // 
            this.chartPat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.chartPat.BorderlineColor = System.Drawing.Color.LightSeaGreen;
            chartArea1.Name = "ChartArea1";
            this.chartPat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPat.Legends.Add(legend1);
            this.chartPat.Location = new System.Drawing.Point(502, 566);
            this.chartPat.Margin = new System.Windows.Forms.Padding(2);
            this.chartPat.Name = "chartPat";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPat.Series.Add(series1);
            this.chartPat.Size = new System.Drawing.Size(567, 215);
            this.chartPat.TabIndex = 13;
            this.chartPat.Text = "Situatie Paturi Sectii";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 66);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(943, 64);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // btnRaport
            // 
            this.btnRaport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRaport.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaport.ForeColor = System.Drawing.Color.White;
            this.btnRaport.Location = new System.Drawing.Point(9, 100);
            this.btnRaport.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(184, 24);
            this.btnRaport.TabIndex = 17;
            this.btnRaport.Text = "Realizează Raport";
            this.btnRaport.UseVisualStyleBackColor = false;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // lblDI
            // 
            this.lblDI.AutoSize = true;
            this.lblDI.BackColor = System.Drawing.SystemColors.Window;
            this.lblDI.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDI.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDI.Location = new System.Drawing.Point(643, 46);
            this.lblDI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDI.Name = "lblDI";
            this.lblDI.Size = new System.Drawing.Size(109, 17);
            this.lblDI.TabIndex = 18;
            this.lblDI.Text = "Data Internării";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.BackColor = System.Drawing.Color.White;
            this.lblDE.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDE.Location = new System.Drawing.Point(959, 46);
            this.lblDE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(110, 17);
            this.lblDE.TabIndex = 19;
            this.lblDE.Text = "Data Externării";
            // 
            // sectiiTableAdapter
            // 
            this.sectiiTableAdapter.ClearBeforeFill = true;
            // 
            // internariTableAdapter
            // 
            this.internariTableAdapter.ClearBeforeFill = true;
            // 
            // queryIntPatBindingSource
            // 
            this.queryIntPatBindingSource.DataMember = "QueryIntPat";
            this.queryIntPatBindingSource.DataSource = this.bazadedate;
            // 
            // btnRaportPaturi
            // 
            this.btnRaportPaturi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRaportPaturi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportPaturi.ForeColor = System.Drawing.Color.White;
            this.btnRaportPaturi.Location = new System.Drawing.Point(9, 567);
            this.btnRaportPaturi.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaportPaturi.Name = "btnRaportPaturi";
            this.btnRaportPaturi.Size = new System.Drawing.Size(136, 24);
            this.btnRaportPaturi.TabIndex = 21;
            this.btnRaportPaturi.Text = "Raport Paturi";
            this.btnRaportPaturi.UseVisualStyleBackColor = false;
            this.btnRaportPaturi.Click += new System.EventHandler(this.btnRaportPaturi_Click);
            // 
            // btnFiltruData
            // 
            this.btnFiltruData.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFiltruData.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltruData.ForeColor = System.Drawing.Color.White;
            this.btnFiltruData.Location = new System.Drawing.Point(787, 64);
            this.btnFiltruData.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltruData.Name = "btnFiltruData";
            this.btnFiltruData.Size = new System.Drawing.Size(136, 24);
            this.btnFiltruData.TabIndex = 22;
            this.btnFiltruData.Text = "Afișează";
            this.btnFiltruData.UseVisualStyleBackColor = false;
            this.btnFiltruData.Click += new System.EventHandler(this.btnFiltruData_Click);
            // 
            // numarActualPaturiDataGridViewTextBoxColumn
            // 
            this.numarActualPaturiDataGridViewTextBoxColumn.DataPropertyName = "NumarActualPaturi";
            this.numarActualPaturiDataGridViewTextBoxColumn.HeaderText = "NumarActualPaturi";
            this.numarActualPaturiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numarActualPaturiDataGridViewTextBoxColumn.Name = "numarActualPaturiDataGridViewTextBoxColumn";
            this.numarActualPaturiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectieDataGridViewTextBoxColumn1
            // 
            this.sectieDataGridViewTextBoxColumn1.DataPropertyName = "Sectie";
            this.sectieDataGridViewTextBoxColumn1.HeaderText = "Sectie";
            this.sectieDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sectieDataGridViewTextBoxColumn1.Name = "sectieDataGridViewTextBoxColumn1";
            this.sectieDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectieDataGridViewTextBoxColumn1,
            this.numarActualPaturiDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.queryIntPatBindingSource;
            this.dataGridView3.GridColor = System.Drawing.Color.White;
            this.dataGridView3.Location = new System.Drawing.Point(170, 566);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(328, 214);
            this.dataGridView3.TabIndex = 20;
            // 
            // queryIntPatTableAdapter
            // 
            this.queryIntPatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numePacientDataGridViewTextBoxColumn1,
            this.sectieDataGridViewTextBoxColumn2,
            this.dataInternariiDataGridViewTextBoxColumn1,
            this.dataExternariiDataGridViewTextBoxColumn1,
            this.idInternareDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.internariDataBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(576, 100);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(557, 469);
            this.dataGridView2.TabIndex = 23;
            // 
            // numePacientDataGridViewTextBoxColumn1
            // 
            this.numePacientDataGridViewTextBoxColumn1.DataPropertyName = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn1.HeaderText = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn1.Name = "numePacientDataGridViewTextBoxColumn1";
            // 
            // sectieDataGridViewTextBoxColumn2
            // 
            this.sectieDataGridViewTextBoxColumn2.DataPropertyName = "Sectie";
            this.sectieDataGridViewTextBoxColumn2.HeaderText = "Sectie";
            this.sectieDataGridViewTextBoxColumn2.Name = "sectieDataGridViewTextBoxColumn2";
            // 
            // dataInternariiDataGridViewTextBoxColumn1
            // 
            this.dataInternariiDataGridViewTextBoxColumn1.DataPropertyName = "DataInternarii";
            this.dataInternariiDataGridViewTextBoxColumn1.HeaderText = "DataInternarii";
            this.dataInternariiDataGridViewTextBoxColumn1.Name = "dataInternariiDataGridViewTextBoxColumn1";
            // 
            // dataExternariiDataGridViewTextBoxColumn1
            // 
            this.dataExternariiDataGridViewTextBoxColumn1.DataPropertyName = "DataExternarii";
            this.dataExternariiDataGridViewTextBoxColumn1.HeaderText = "DataExternarii";
            this.dataExternariiDataGridViewTextBoxColumn1.Name = "dataExternariiDataGridViewTextBoxColumn1";
            // 
            // idInternareDataGridViewTextBoxColumn1
            // 
            this.idInternareDataGridViewTextBoxColumn1.DataPropertyName = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn1.HeaderText = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn1.Name = "idInternareDataGridViewTextBoxColumn1";
            // 
            // internariDataBindingSource
            // 
            this.internariDataBindingSource.DataMember = "InternariData";
            this.internariDataBindingSource.DataSource = this.bazadedate;
            // 
            // internariDataTableAdapter
            // 
            this.internariDataTableAdapter.ClearBeforeFill = true;
            // 
            // RapoarteInternari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 808);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnFiltruData);
            this.Controls.Add(this.btnRaportPaturi);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.lblDI);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chartPat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RapoarteInternari";
            this.Text = "Rapoarte Internari";
            this.Load += new System.EventHandler(this.RapoarteInternari_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryIntPatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primiriUrgențeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteUPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteInternăriToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Label lblDI;
        private System.Windows.Forms.Label lblDE;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource sectiiBindingSource;
        private bazadedateTableAdapters.SectiiTableAdapter sectiiTableAdapter;
        private bazadedateTableAdapters.InternariTableAdapter internariTableAdapter;
        private System.Windows.Forms.Button btnRaportPaturi;
        private System.Windows.Forms.Button btnFiltruData;
        private System.Windows.Forms.BindingSource queryIntPatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarTotalPaturiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource internariBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarActualPaturiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private bazadedateTableAdapters.QueryIntPatTableAdapter queryIntPatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInternareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInternariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExternariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epicrizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozaCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource internariBindingSource1;
        private System.Windows.Forms.BindingSource bazadedateBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectieDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInternariiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExternariiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInternareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource internariDataBindingSource;
        private bazadedateTableAdapters.InternariDataTableAdapter internariDataTableAdapter;
    }
}