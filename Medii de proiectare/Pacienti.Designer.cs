namespace Proiect
{
    partial class Pacienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacienti));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUrgentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decizieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedate = new Proiect.bazadedate();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboDecizie = new System.Windows.Forms.ComboBox();
            this.comboCod = new System.Windows.Forms.ComboBox();
            this.codUrgentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedate1 = new Proiect.bazadedate();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtIdPacient = new System.Windows.Forms.TextBox();
            this.lblDecizie = new System.Windows.Forms.Label();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.lblNumepPacient = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblCodUrgenta = new System.Windows.Forms.Label();
            this.lblIdpacient = new System.Windows.Forms.Label();
            this.lblOperatiune = new System.Windows.Forms.Label();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.pacientiTableAdapter = new Proiect.bazadedateTableAdapters.PacientiTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primiriUrgențeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteUPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteInternăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codUrgentaTableAdapter = new Proiect.bazadedateTableAdapters.CodUrgentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codUrgentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacientDataGridViewTextBoxColumn,
            this.numePacientDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.codUrgentaDataGridViewTextBoxColumn,
            this.diagnosticDataGridViewTextBoxColumn,
            this.decizieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPacientDataGridViewTextBoxColumn
            // 
            this.idPacientDataGridViewTextBoxColumn.DataPropertyName = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.HeaderText = "IdPacient";
            this.idPacientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPacientDataGridViewTextBoxColumn.Name = "idPacientDataGridViewTextBoxColumn";
            this.idPacientDataGridViewTextBoxColumn.Visible = false;
            this.idPacientDataGridViewTextBoxColumn.Width = 125;
            // 
            // numePacientDataGridViewTextBoxColumn
            // 
            this.numePacientDataGridViewTextBoxColumn.DataPropertyName = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.HeaderText = "NumePacient";
            this.numePacientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numePacientDataGridViewTextBoxColumn.Name = "numePacientDataGridViewTextBoxColumn";
            this.numePacientDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // codUrgentaDataGridViewTextBoxColumn
            // 
            this.codUrgentaDataGridViewTextBoxColumn.DataPropertyName = "CodUrgenta";
            this.codUrgentaDataGridViewTextBoxColumn.HeaderText = "CodUrgenta";
            this.codUrgentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codUrgentaDataGridViewTextBoxColumn.Name = "codUrgentaDataGridViewTextBoxColumn";
            this.codUrgentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // diagnosticDataGridViewTextBoxColumn
            // 
            this.diagnosticDataGridViewTextBoxColumn.DataPropertyName = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.HeaderText = "Diagnostic";
            this.diagnosticDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnosticDataGridViewTextBoxColumn.Name = "diagnosticDataGridViewTextBoxColumn";
            this.diagnosticDataGridViewTextBoxColumn.Width = 125;
            // 
            // decizieDataGridViewTextBoxColumn
            // 
            this.decizieDataGridViewTextBoxColumn.DataPropertyName = "Decizie";
            this.decizieDataGridViewTextBoxColumn.HeaderText = "Decizie";
            this.decizieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.decizieDataGridViewTextBoxColumn.Name = "decizieDataGridViewTextBoxColumn";
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
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.Red;
            this.btnAdaugare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.Color.White;
            this.btnAdaugare.Location = new System.Drawing.Point(26, 54);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(154, 38);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adăugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboDecizie);
            this.panel1.Controls.Add(this.comboCod);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtDiagnostic);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtCNP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.pnlId);
            this.panel1.Controls.Add(this.txtIdPacient);
            this.panel1.Controls.Add(this.lblDecizie);
            this.panel1.Controls.Add(this.lblDiagnostic);
            this.panel1.Controls.Add(this.lblNumepPacient);
            this.panel1.Controls.Add(this.lblCNP);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.lblCodUrgenta);
            this.panel1.Controls.Add(this.lblIdpacient);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(971, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 453);
            this.panel1.TabIndex = 2;
            // 
            // comboDecizie
            // 
            this.comboDecizie.BackColor = System.Drawing.Color.White;
            this.comboDecizie.ForeColor = System.Drawing.Color.Black;
            this.comboDecizie.FormattingEnabled = true;
            this.comboDecizie.Items.AddRange(new object[] {
            "Intrat UPU",
            "Ambulator",
            "Internare",
            "Transfer"});
            this.comboDecizie.Location = new System.Drawing.Point(230, 346);
            this.comboDecizie.Name = "comboDecizie";
            this.comboDecizie.Size = new System.Drawing.Size(154, 30);
            this.comboDecizie.TabIndex = 25;
            // 
            // comboCod
            // 
            this.comboCod.BackColor = System.Drawing.Color.White;
            this.comboCod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.codUrgentaBindingSource, "DCodUrgenta", true));
            this.comboCod.DataSource = this.codUrgentaBindingSource;
            this.comboCod.DisplayMember = "DCodUrgenta";
            this.comboCod.ForeColor = System.Drawing.Color.Black;
            this.comboCod.FormattingEnabled = true;
            this.comboCod.Location = new System.Drawing.Point(230, 248);
            this.comboCod.Name = "comboCod";
            this.comboCod.Size = new System.Drawing.Size(154, 30);
            this.comboCod.TabIndex = 24;
            this.comboCod.ValueMember = "DCodUrgenta";
            // 
            // codUrgentaBindingSource
            // 
            this.codUrgentaBindingSource.DataMember = "CodUrgenta";
            this.codUrgentaBindingSource.DataSource = this.bazadedate1;
            // 
            // bazadedate1
            // 
            this.bazadedate1.DataSetName = "bazadedate";
            this.bazadedate1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(182, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 1);
            this.panel5.TabIndex = 23;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiagnostic.Location = new System.Drawing.Point(182, 292);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(271, 22);
            this.txtDiagnostic.TabIndex = 22;
            this.txtDiagnostic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(182, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 1);
            this.panel4.TabIndex = 23;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Location = new System.Drawing.Point(182, 193);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(271, 22);
            this.txtTelefon.TabIndex = 22;
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(182, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 1);
            this.panel3.TabIndex = 21;
            // 
            // txtCNP
            // 
            this.txtCNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCNP.Location = new System.Drawing.Point(182, 141);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(271, 22);
            this.txtCNP.TabIndex = 20;
            this.txtCNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(182, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 1);
            this.panel2.TabIndex = 19;
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNume.Location = new System.Drawing.Point(182, 87);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(271, 22);
            this.txtNume.TabIndex = 18;
            this.txtNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.Red;
            this.pnlId.Location = new System.Drawing.Point(154, 56);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(143, 1);
            this.pnlId.TabIndex = 17;
            // 
            // txtIdPacient
            // 
            this.txtIdPacient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPacient.Location = new System.Drawing.Point(154, 32);
            this.txtIdPacient.Name = "txtIdPacient";
            this.txtIdPacient.Size = new System.Drawing.Size(143, 22);
            this.txtIdPacient.TabIndex = 16;
            this.txtIdPacient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDecizie
            // 
            this.lblDecizie.AutoSize = true;
            this.lblDecizie.BackColor = System.Drawing.Color.White;
            this.lblDecizie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecizie.ForeColor = System.Drawing.Color.Red;
            this.lblDecizie.Location = new System.Drawing.Point(51, 346);
            this.lblDecizie.Name = "lblDecizie";
            this.lblDecizie.Size = new System.Drawing.Size(64, 22);
            this.lblDecizie.TabIndex = 15;
            this.lblDecizie.Text = "Decizie";
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.BackColor = System.Drawing.Color.White;
            this.lblDiagnostic.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostic.ForeColor = System.Drawing.Color.Red;
            this.lblDiagnostic.Location = new System.Drawing.Point(46, 295);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(91, 22);
            this.lblDiagnostic.TabIndex = 14;
            this.lblDiagnostic.Text = "Diagnostic";
            // 
            // lblNumepPacient
            // 
            this.lblNumepPacient.AutoSize = true;
            this.lblNumepPacient.BackColor = System.Drawing.Color.White;
            this.lblNumepPacient.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumepPacient.ForeColor = System.Drawing.Color.Red;
            this.lblNumepPacient.Location = new System.Drawing.Point(15, 90);
            this.lblNumepPacient.Name = "lblNumepPacient";
            this.lblNumepPacient.Size = new System.Drawing.Size(155, 22);
            this.lblNumepPacient.TabIndex = 13;
            this.lblNumepPacient.Text = "Nume și Prenume ";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.BackColor = System.Drawing.Color.White;
            this.lblCNP.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.ForeColor = System.Drawing.Color.Red;
            this.lblCNP.Location = new System.Drawing.Point(60, 144);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(43, 22);
            this.lblCNP.TabIndex = 12;
            this.lblCNP.Text = "CNP";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.White;
            this.lblTelefon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.ForeColor = System.Drawing.Color.Red;
            this.lblTelefon.Location = new System.Drawing.Point(46, 196);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 22);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblCodUrgenta
            // 
            this.lblCodUrgenta.AutoSize = true;
            this.lblCodUrgenta.BackColor = System.Drawing.Color.White;
            this.lblCodUrgenta.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUrgenta.ForeColor = System.Drawing.Color.Red;
            this.lblCodUrgenta.Location = new System.Drawing.Point(39, 251);
            this.lblCodUrgenta.Name = "lblCodUrgenta";
            this.lblCodUrgenta.Size = new System.Drawing.Size(109, 22);
            this.lblCodUrgenta.TabIndex = 10;
            this.lblCodUrgenta.Text = "Cod Urgență";
            // 
            // lblIdpacient
            // 
            this.lblIdpacient.AutoSize = true;
            this.lblIdpacient.BackColor = System.Drawing.Color.White;
            this.lblIdpacient.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdpacient.ForeColor = System.Drawing.Color.Red;
            this.lblIdpacient.Location = new System.Drawing.Point(39, 35);
            this.lblIdpacient.Name = "lblIdpacient";
            this.lblIdpacient.Size = new System.Drawing.Size(89, 22);
            this.lblIdpacient.TabIndex = 8;
            this.lblIdpacient.Text = "Id Pacient";
            // 
            // lblOperatiune
            // 
            this.lblOperatiune.AutoSize = true;
            this.lblOperatiune.BackColor = System.Drawing.Color.White;
            this.lblOperatiune.ForeColor = System.Drawing.Color.Red;
            this.lblOperatiune.Location = new System.Drawing.Point(1422, 76);
            this.lblOperatiune.Name = "lblOperatiune";
            this.lblOperatiune.Size = new System.Drawing.Size(87, 16);
            this.lblOperatiune.TabIndex = 3;
            this.lblOperatiune.Text = "lblOperatiune";
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.BackColor = System.Drawing.Color.Red;
            this.btnRenuntare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.ForeColor = System.Drawing.Color.White;
            this.btnRenuntare.Location = new System.Drawing.Point(1147, 54);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(154, 38);
            this.btnRenuntare.TabIndex = 4;
            this.btnRenuntare.Text = "Renunță";
            this.btnRenuntare.UseVisualStyleBackColor = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.BackColor = System.Drawing.Color.Red;
            this.btnConfirmare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.ForeColor = System.Drawing.Color.White;
            this.btnConfirmare.Location = new System.Drawing.Point(976, 54);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(165, 38);
            this.btnConfirmare.TabIndex = 5;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = false;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.Color.Red;
            this.btnModificare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.ForeColor = System.Drawing.Color.White;
            this.btnModificare.Location = new System.Drawing.Point(217, 54);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(159, 38);
            this.btnModificare.TabIndex = 6;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = false;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.Red;
            this.btnStergere.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(420, 54);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(148, 38);
            this.btnStergere.TabIndex = 7;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1524, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primiriUrgențeToolStripMenuItem
            // 
            this.primiriUrgențeToolStripMenuItem.Name = "primiriUrgențeToolStripMenuItem";
            this.primiriUrgențeToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.primiriUrgențeToolStripMenuItem.Text = "Primiri Urgențe";
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
            this.rapoarteUPUToolStripMenuItem.Click += new System.EventHandler(this.rapoarteUPUToolStripMenuItem_Click);
            // 
            // rapoarteInternăriToolStripMenuItem
            // 
            this.rapoarteInternăriToolStripMenuItem.Name = "rapoarteInternăriToolStripMenuItem";
            this.rapoarteInternăriToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.rapoarteInternăriToolStripMenuItem.Text = "Rapoarte Internări";
            this.rapoarteInternăriToolStripMenuItem.Click += new System.EventHandler(this.rapoarteInternăriToolStripMenuItem_Click);
            // 
            // codUrgentaTableAdapter
            // 
            this.codUrgentaTableAdapter.ClearBeforeFill = true;
            // 
            // Pacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1524, 585);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.lblOperatiune);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pacienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primiri Urgențe - UPU";
            this.Load += new System.EventHandler(this.Pacienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codUrgentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOperatiune;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private bazadedateTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private System.Windows.Forms.ComboBox comboCod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtIdPacient;
        private System.Windows.Forms.Label lblDecizie;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Label lblNumepPacient;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblCodUrgenta;
        private System.Windows.Forms.Label lblIdpacient;
        private System.Windows.Forms.ComboBox comboDecizie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primiriUrgențeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteUPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteInternăriToolStripMenuItem;
        private bazadedate bazadedate1;
        private System.Windows.Forms.BindingSource codUrgentaBindingSource;
        private bazadedateTableAdapters.CodUrgentaTableAdapter codUrgentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUrgentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decizieDataGridViewTextBoxColumn;
    }
}