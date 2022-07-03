namespace Proiect
{
    partial class Internari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Internari));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primiriUrgențeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteUPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteInternăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpozacard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPozacardText = new System.Windows.Forms.Label();
            this.pozacardsanatate = new System.Windows.Forms.PictureBox();
            this.dataexternare = new System.Windows.Forms.DateTimePicker();
            this.datainternare = new System.Windows.Forms.DateTimePicker();
            this.lbldataexternare = new System.Windows.Forms.Label();
            this.comboSectie = new System.Windows.Forms.ComboBox();
            this.sectiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedate = new Proiect.bazadedate();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEpicriza = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumePacient = new System.Windows.Forms.TextBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtIdInternare = new System.Windows.Forms.TextBox();
            this.lblEpicriza = new System.Windows.Forms.Label();
            this.lblNumeP = new System.Windows.Forms.Label();
            this.lblDataInternare = new System.Windows.Forms.Label();
            this.lblSectie = new System.Windows.Forms.Label();
            this.lblidInternare = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.internariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOperatiune = new System.Windows.Forms.Label();
            this.sectiiTableAdapter = new Proiect.bazadedateTableAdapters.SectiiTableAdapter();
            this.internariTableAdapter = new Proiect.bazadedateTableAdapters.InternariTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.idInternareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePacientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInternariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExternariiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epicrizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozaCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panelprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozacardsanatate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1582, 29);
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
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStergere.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(435, 48);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(148, 38);
            this.btnStergere.TabIndex = 16;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.ForeColor = System.Drawing.Color.White;
            this.btnModificare.Location = new System.Drawing.Point(232, 48);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(159, 38);
            this.btnModificare.TabIndex = 15;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = false;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirmare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.ForeColor = System.Drawing.Color.White;
            this.btnConfirmare.Location = new System.Drawing.Point(991, 48);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(165, 38);
            this.btnConfirmare.TabIndex = 14;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = false;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRenuntare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.ForeColor = System.Drawing.Color.White;
            this.btnRenuntare.Location = new System.Drawing.Point(1162, 48);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(154, 38);
            this.btnRenuntare.TabIndex = 13;
            this.btnRenuntare.Text = "Renunță";
            this.btnRenuntare.UseVisualStyleBackColor = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // panelprincipal
            // 
            this.panelprincipal.Controls.Add(this.panel1);
            this.panelprincipal.Controls.Add(this.txtpozacard);
            this.panelprincipal.Controls.Add(this.label2);
            this.panelprincipal.Controls.Add(this.lblPozacardText);
            this.panelprincipal.Controls.Add(this.pozacardsanatate);
            this.panelprincipal.Controls.Add(this.dataexternare);
            this.panelprincipal.Controls.Add(this.datainternare);
            this.panelprincipal.Controls.Add(this.lbldataexternare);
            this.panelprincipal.Controls.Add(this.comboSectie);
            this.panelprincipal.Controls.Add(this.panel5);
            this.panelprincipal.Controls.Add(this.txtEpicriza);
            this.panelprincipal.Controls.Add(this.panel2);
            this.panelprincipal.Controls.Add(this.txtNumePacient);
            this.panelprincipal.Controls.Add(this.pnlId);
            this.panelprincipal.Controls.Add(this.txtIdInternare);
            this.panelprincipal.Controls.Add(this.lblEpicriza);
            this.panelprincipal.Controls.Add(this.lblNumeP);
            this.panelprincipal.Controls.Add(this.lblDataInternare);
            this.panelprincipal.Controls.Add(this.lblSectie);
            this.panelprincipal.Controls.Add(this.lblidInternare);
            this.panelprincipal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelprincipal.Location = new System.Drawing.Point(986, 92);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(538, 633);
            this.panelprincipal.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(195, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 1);
            this.panel1.TabIndex = 26;
            // 
            // txtpozacard
            // 
            this.txtpozacard.BackColor = System.Drawing.Color.White;
            this.txtpozacard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpozacard.ForeColor = System.Drawing.Color.Black;
            this.txtpozacard.Location = new System.Drawing.Point(195, 558);
            this.txtpozacard.Name = "txtpozacard";
            this.txtpozacard.Size = new System.Drawing.Size(271, 22);
            this.txtpozacard.TabIndex = 25;
            this.txtpozacard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(191, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Poză Card Sănătate";
            // 
            // lblPozacardText
            // 
            this.lblPozacardText.AutoSize = true;
            this.lblPozacardText.BackColor = System.Drawing.Color.White;
            this.lblPozacardText.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozacardText.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPozacardText.Location = new System.Drawing.Point(59, 561);
            this.lblPozacardText.Name = "lblPozacardText";
            this.lblPozacardText.Size = new System.Drawing.Size(129, 22);
            this.lblPozacardText.TabIndex = 24;
            this.lblPozacardText.Text = "Cale fișier poză";
            // 
            // pozacardsanatate
            // 
            this.pozacardsanatate.Location = new System.Drawing.Point(34, 392);
            this.pozacardsanatate.Name = "pozacardsanatate";
            this.pozacardsanatate.Size = new System.Drawing.Size(474, 153);
            this.pozacardsanatate.TabIndex = 29;
            this.pozacardsanatate.TabStop = false;
            // 
            // dataexternare
            // 
            this.dataexternare.Location = new System.Drawing.Point(218, 297);
            this.dataexternare.Name = "dataexternare";
            this.dataexternare.Size = new System.Drawing.Size(200, 29);
            this.dataexternare.TabIndex = 28;
            // 
            // datainternare
            // 
            this.datainternare.CalendarForeColor = System.Drawing.Color.LightSeaGreen;
            this.datainternare.CalendarMonthBackground = System.Drawing.Color.White;
            this.datainternare.Location = new System.Drawing.Point(218, 139);
            this.datainternare.Name = "datainternare";
            this.datainternare.Size = new System.Drawing.Size(200, 29);
            this.datainternare.TabIndex = 27;
            // 
            // lbldataexternare
            // 
            this.lbldataexternare.AutoSize = true;
            this.lbldataexternare.BackColor = System.Drawing.Color.White;
            this.lbldataexternare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataexternare.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbldataexternare.Location = new System.Drawing.Point(30, 304);
            this.lbldataexternare.Name = "lbldataexternare";
            this.lbldataexternare.Size = new System.Drawing.Size(125, 22);
            this.lbldataexternare.TabIndex = 26;
            this.lbldataexternare.Text = "Data Externării";
            // 
            // comboSectie
            // 
            this.comboSectie.BackColor = System.Drawing.Color.White;
            this.comboSectie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectiiBindingSource, "DSectie", true));
            this.comboSectie.DataSource = this.sectiiBindingSource;
            this.comboSectie.DisplayMember = "DSectie";
            this.comboSectie.ForeColor = System.Drawing.Color.Black;
            this.comboSectie.FormattingEnabled = true;
            this.comboSectie.Location = new System.Drawing.Point(195, 195);
            this.comboSectie.Name = "comboSectie";
            this.comboSectie.Size = new System.Drawing.Size(271, 30);
            this.comboSectie.TabIndex = 24;
            this.comboSectie.ValueMember = "DSectie";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Location = new System.Drawing.Point(195, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 1);
            this.panel5.TabIndex = 23;
            // 
            // txtEpicriza
            // 
            this.txtEpicriza.BackColor = System.Drawing.Color.White;
            this.txtEpicriza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEpicriza.ForeColor = System.Drawing.Color.Black;
            this.txtEpicriza.Location = new System.Drawing.Point(195, 243);
            this.txtEpicriza.Name = "txtEpicriza";
            this.txtEpicriza.Size = new System.Drawing.Size(271, 22);
            this.txtEpicriza.TabIndex = 22;
            this.txtEpicriza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Location = new System.Drawing.Point(182, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 1);
            this.panel2.TabIndex = 19;
            // 
            // txtNumePacient
            // 
            this.txtNumePacient.BackColor = System.Drawing.Color.White;
            this.txtNumePacient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumePacient.ForeColor = System.Drawing.Color.Black;
            this.txtNumePacient.Location = new System.Drawing.Point(182, 87);
            this.txtNumePacient.Name = "txtNumePacient";
            this.txtNumePacient.Size = new System.Drawing.Size(271, 22);
            this.txtNumePacient.TabIndex = 18;
            this.txtNumePacient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlId.Location = new System.Drawing.Point(154, 56);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(98, 1);
            this.pnlId.TabIndex = 17;
            // 
            // txtIdInternare
            // 
            this.txtIdInternare.BackColor = System.Drawing.Color.White;
            this.txtIdInternare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdInternare.ForeColor = System.Drawing.Color.Black;
            this.txtIdInternare.Location = new System.Drawing.Point(154, 32);
            this.txtIdInternare.Name = "txtIdInternare";
            this.txtIdInternare.Size = new System.Drawing.Size(98, 22);
            this.txtIdInternare.TabIndex = 16;
            this.txtIdInternare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEpicriza
            // 
            this.lblEpicriza.AutoSize = true;
            this.lblEpicriza.BackColor = System.Drawing.Color.White;
            this.lblEpicriza.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpicriza.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblEpicriza.Location = new System.Drawing.Point(59, 246);
            this.lblEpicriza.Name = "lblEpicriza";
            this.lblEpicriza.Size = new System.Drawing.Size(69, 22);
            this.lblEpicriza.TabIndex = 14;
            this.lblEpicriza.Text = "Epicriza";
            // 
            // lblNumeP
            // 
            this.lblNumeP.AutoSize = true;
            this.lblNumeP.BackColor = System.Drawing.Color.White;
            this.lblNumeP.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeP.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNumeP.Location = new System.Drawing.Point(15, 90);
            this.lblNumeP.Name = "lblNumeP";
            this.lblNumeP.Size = new System.Drawing.Size(155, 22);
            this.lblNumeP.TabIndex = 13;
            this.lblNumeP.Text = "Nume și Prenume ";
            // 
            // lblDataInternare
            // 
            this.lblDataInternare.AutoSize = true;
            this.lblDataInternare.BackColor = System.Drawing.Color.White;
            this.lblDataInternare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInternare.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDataInternare.Location = new System.Drawing.Point(30, 144);
            this.lblDataInternare.Name = "lblDataInternare";
            this.lblDataInternare.Size = new System.Drawing.Size(123, 22);
            this.lblDataInternare.TabIndex = 12;
            this.lblDataInternare.Text = "Data Internării";
            // 
            // lblSectie
            // 
            this.lblSectie.AutoSize = true;
            this.lblSectie.BackColor = System.Drawing.Color.White;
            this.lblSectie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectie.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSectie.Location = new System.Drawing.Point(59, 195);
            this.lblSectie.Name = "lblSectie";
            this.lblSectie.Size = new System.Drawing.Size(56, 22);
            this.lblSectie.TabIndex = 10;
            this.lblSectie.Text = "Secție";
            // 
            // lblidInternare
            // 
            this.lblidInternare.AutoSize = true;
            this.lblidInternare.BackColor = System.Drawing.Color.White;
            this.lblidInternare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidInternare.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblidInternare.Location = new System.Drawing.Point(39, 35);
            this.lblidInternare.Name = "lblidInternare";
            this.lblidInternare.Size = new System.Drawing.Size(105, 22);
            this.lblidInternare.TabIndex = 8;
            this.lblidInternare.Text = "Id Internare";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdaugare.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.ForeColor = System.Drawing.Color.White;
            this.btnAdaugare.Location = new System.Drawing.Point(41, 48);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(154, 38);
            this.btnAdaugare.TabIndex = 11;
            this.btnAdaugare.Text = "Adăugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dataGridView1.DataSource = this.internariBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(27, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 633);
            this.dataGridView1.TabIndex = 10;
            // 
            // internariBindingSource
            // 
            this.internariBindingSource.DataMember = "Internari";
            this.internariBindingSource.DataSource = this.bazadedate;
            // 
            // lblOperatiune
            // 
            this.lblOperatiune.AutoSize = true;
            this.lblOperatiune.BackColor = System.Drawing.Color.White;
            this.lblOperatiune.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblOperatiune.Location = new System.Drawing.Point(1437, 70);
            this.lblOperatiune.Name = "lblOperatiune";
            this.lblOperatiune.Size = new System.Drawing.Size(87, 16);
            this.lblOperatiune.TabIndex = 17;
            this.lblOperatiune.Text = "lblOperatiune";
            // 
            // sectiiTableAdapter
            // 
            this.sectiiTableAdapter.ClearBeforeFill = true;
            // 
            // internariTableAdapter
            // 
            this.internariTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // idInternareDataGridViewTextBoxColumn
            // 
            this.idInternareDataGridViewTextBoxColumn.DataPropertyName = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn.HeaderText = "IdInternare";
            this.idInternareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idInternareDataGridViewTextBoxColumn.Name = "idInternareDataGridViewTextBoxColumn";
            this.idInternareDataGridViewTextBoxColumn.Width = 125;
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
            // sectieDataGridViewTextBoxColumn
            // 
            this.sectieDataGridViewTextBoxColumn.DataPropertyName = "Sectie";
            this.sectieDataGridViewTextBoxColumn.HeaderText = "Sectie";
            this.sectieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectieDataGridViewTextBoxColumn.Name = "sectieDataGridViewTextBoxColumn";
            this.sectieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataInternariiDataGridViewTextBoxColumn
            // 
            this.dataInternariiDataGridViewTextBoxColumn.DataPropertyName = "DataInternarii";
            this.dataInternariiDataGridViewTextBoxColumn.HeaderText = "DataInternarii";
            this.dataInternariiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataInternariiDataGridViewTextBoxColumn.Name = "dataInternariiDataGridViewTextBoxColumn";
            this.dataInternariiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExternariiDataGridViewTextBoxColumn
            // 
            this.dataExternariiDataGridViewTextBoxColumn.DataPropertyName = "DataExternarii";
            this.dataExternariiDataGridViewTextBoxColumn.HeaderText = "DataExternarii";
            this.dataExternariiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExternariiDataGridViewTextBoxColumn.Name = "dataExternariiDataGridViewTextBoxColumn";
            this.dataExternariiDataGridViewTextBoxColumn.Width = 125;
            // 
            // epicrizaDataGridViewTextBoxColumn
            // 
            this.epicrizaDataGridViewTextBoxColumn.DataPropertyName = "Epicriza";
            this.epicrizaDataGridViewTextBoxColumn.HeaderText = "Epicriza";
            this.epicrizaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.epicrizaDataGridViewTextBoxColumn.Name = "epicrizaDataGridViewTextBoxColumn";
            this.epicrizaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pozaCardDataGridViewTextBoxColumn
            // 
            this.pozaCardDataGridViewTextBoxColumn.DataPropertyName = "PozaCard";
            this.pozaCardDataGridViewTextBoxColumn.HeaderText = "PozaCard";
            this.pozaCardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pozaCardDataGridViewTextBoxColumn.Name = "pozaCardDataGridViewTextBoxColumn";
            this.pozaCardDataGridViewTextBoxColumn.Width = 125;
            // 
            // Internari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 759);
            this.Controls.Add(this.lblOperatiune);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Internari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internari";
            this.Load += new System.EventHandler(this.Internari_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelprincipal.ResumeLayout(false);
            this.panelprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozacardsanatate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internariBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.ComboBox comboSectie;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtEpicriza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumePacient;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtIdInternare;
        private System.Windows.Forms.Label lblEpicriza;
        private System.Windows.Forms.Label lblNumeP;
        private System.Windows.Forms.Label lblDataInternare;
        private System.Windows.Forms.Label lblSectie;
        private System.Windows.Forms.Label lblidInternare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOperatiune;
        private bazadedate bazadedate;
        private System.Windows.Forms.BindingSource sectiiBindingSource;
        private bazadedateTableAdapters.SectiiTableAdapter sectiiTableAdapter;
        private System.Windows.Forms.PictureBox pozacardsanatate;
        private System.Windows.Forms.DateTimePicker dataexternare;
        private System.Windows.Forms.DateTimePicker datainternare;
        private System.Windows.Forms.Label lbldataexternare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource internariBindingSource;
        private bazadedateTableAdapters.InternariTableAdapter internariTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpozacard;
        private System.Windows.Forms.Label lblPozacardText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInternareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePacientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInternariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExternariiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epicrizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozaCardDataGridViewTextBoxColumn;
    }
}