using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect{
    public partial class Pacienti : Form{
        public Pacienti(){
            InitializeComponent();
        }
        private void Pacienti_Load(object sender, EventArgs e){
            this.codUrgentaTableAdapter.Fill(this.bazadedate1.CodUrgenta);
            A1();
        }
        private void A1(){
            this.pacientiTableAdapter.Fill(this.bazadedate.Pacienti);
            //Initiez protectia la nivelul gridului:
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            A3();
        }
        private void A2(){
            //Configurez butoanele
            configureazaButoane(false);
            //Dezleg controalele 
            legareControale(false);
            //"Ridic" protectia controalelor de la nivelul Panelului
            protectiePanel(false);
            //Modifc label de Operatiune in Adaugare lblOp
            lblOperatiune.Text = "ADAUG";
            //Pun "focus" pe primul camp de commpletare
            txtNume.Focus();
            // Golesc campurile
            golireCampuri();
        }
        private void A3(){
            //Initializez label pentru Operatiune drept null;
            lblOperatiune.Text = "";
            //Çonfigurez butoanele
            configureazaButoane(true);
            //Pun Protectie pe componentele din Panel
            protectiePanel(true);
            //Leg controalele
            legareControale(true);
        }
        private void A4(){
            if (lblOperatiune.Text == "ADAUG"){
                if (!validareCampuri()) return;//conditie ca campurile sa fie completate inainte de adaugare
                adauga_pacient();//chem functia de adaugare
                golireCampuri();//Golesc campurile, preg pentru urm adaugare
                txtNume.Focus();//Pun focus pe primul camp de completare
                refresh_grid(pacientiBindingSource.Position);//Reactualizez/updatez grid-ul, pentru a vizualiza in timp real Adaugarea;
            }else if (lblOperatiune.Text == "MODIFIC"){
                if (!validareCampuri()) return;//conditie ca campurile sa fie completate inainte de modificare
                modific_pacient();//chem functia de modificare
                refresh_grid(pacientiBindingSource.Position);//Reactualizez/updatez grid-ul, pentru a vizualiza in timp real Modificarea;
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }
        private void A5(){
            //Configurez butoanele
            configureazaButoane(false);
            //Dezleg controalele din Panel
            legareControale(false);
            //Ridic protectia pusa pe controalele din Panel
            protectiePanel(false);
            //Modifc label-ul pentru Operatiune cu 'Modific'
            lblOperatiune.Text = "MODIFIC";
            //Pun focus pe primul camp de completare
            txtNume.Focus();
        }
        private void A6(){
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            //OleDbDataReader rdr;
            con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;//82->86 am realizat conexiunea la baza de date cu variabilele in uz
            cmd.CommandText = "DELETE FROM Pacienti WHERE IdPacient = " + txtIdPacient.Text;//comanda de tip SQL ce realizeaza stergerea din baza de date ACCESS
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();//execut comanda SQL
            con.Close();
            refresh_grid(pacientiBindingSource.Position);//Reactualizez/updatez grid-ul, pentru a vizualiza in timp real Stergerea;
        }
        private void configureazaButoane(bool v){
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void legareControale(bool v){
            if (v){
                txtIdPacient.DataBindings.Add("Text", pacientiBindingSource, "IdPacient");
                txtNume.DataBindings.Add("Text", pacientiBindingSource, "NumePacient");
                txtTelefon.DataBindings.Add("Text", pacientiBindingSource, "NrTelefon");
                txtCNP.DataBindings.Add("Text", pacientiBindingSource, "CNP");
                txtDiagnostic.DataBindings.Add("Text", pacientiBindingSource, "Diagnostic");
                comboCod.DataBindings.Add("Text", pacientiBindingSource, "CodUrgenta");
                comboDecizie.DataBindings.Add("Text", pacientiBindingSource, "Decizie");
            }else{ 
                txtIdPacient.DataBindings.Clear();
                txtNume.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtTelefon.DataBindings.Clear();
                txtDiagnostic.DataBindings.Clear();
                comboCod.DataBindings.Clear();
                comboDecizie.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v){
            txtNume.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtDiagnostic.ReadOnly = v;
            txtTelefon.ReadOnly = v;
            comboCod.Enabled = !v;
            comboDecizie.Enabled = !v;
        }
        private void golireCampuri(){
            txtIdPacient.Text = "";
            txtNume.Text = "";
            txtCNP.Text = "";
            txtTelefon.Text = "";
            txtDiagnostic.Text = "";
            comboDecizie.SelectedIndex = 0;
            comboCod.SelectedIndex = 0;
        }
        private void refresh_grid(int p){
            pacientiTableAdapter.Fill(bazadedate.Pacienti);
            pacientiBindingSource.Position = p;
        }
        private bool validareCampuri(){
            if(txtNume.Text == ""){
                MessageBox.Show("Completati numele și prenumele pacientului.");
                txtNume.Focus();
                return false;
            }
            if (txtTelefon.Text == ""){
                MessageBox.Show("Completati numărul de telefon al pacientului.");
                txtTelefon.Focus();
                return false;
            }
            if (txtDiagnostic.Text == ""){
                MessageBox.Show("Completati diagnostic de urgență al pacientului.");
                txtDiagnostic.Focus();
                return false;
            }
            if(txtCNP.Text == ""){
                MessageBox.Show("Completati Codul Numeric Personal al pacientului.");
                txtCNP.Focus();
                return false;
            }
            if (comboCod.SelectedIndex == -1) {
                MessageBox.Show("Completati codul de urgență al pacientului.");
                comboCod.Focus();
                return false;
            }
            if (comboDecizie.SelectedIndex == -1){
                MessageBox.Show("Completati decizia actuală a pacientului.");
                comboDecizie.Focus();
                return false;
            }
            return true;
        }
        private void adauga_pacient(){
            string ListaAccess;//Initiez o lista cu valorile coloanelor din access
            string ListaText;//initiez o lista cu controalele/campurile de completat
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;//initiez conexiunea la baza de date
            ListaAccess = "NumePacient, CNP, NrTelefon, CodUrgenta, Diagnostic, Decizie";
            ListaText = "'" + txtNume.Text + "'" +
                        ",'" + txtCNP.Text + "'" +
                        ",'" + txtTelefon.Text + "'" +
                        ",'" + comboCod.SelectedValue + "'"+
                        ",'" + txtDiagnostic.Text + "'" +
                        ",'" + comboDecizie.SelectedItem + "'";
            cmd.CommandText = "INSERT INTO Pacienti(" + ListaAccess + ") " + " SELECT " + ListaText ;//comanda de tip SQL pentru Adaugarea pacientului in baza de date;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();//execut comanda SQL
            con.Close();
        }
        private void modific_pacient(){
            string Lista;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = pacientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            Lista = "NumePacient = '" + txtNume.Text + "'," +
                    "NrTelefon = '" + txtTelefon.Text + "'," +
                    "Diagnostic = '" + txtDiagnostic.Text + "'," +
                    "CNP = '" + txtCNP.Text + "'," +
                    "CodUrgenta = '" + comboCod.SelectedValue + "'," +
                    "Decizie = '" + comboDecizie.SelectedItem + "'"; 
            cmd.CommandText = "UPDATE Pacienti SET " + Lista + " WHERE IdPacient=" + txtIdPacient.Text;//comanda de tip SQL pentru Modificarea pacientului in baza de date;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();//execut comanda SQL
            con.Close();
        }
        private void internăriToolStripMenuItem_Click(object sender, EventArgs e){
            Internari intern = new Internari();
            intern.Show();
            this.Hide();
        }
        private void rapoarteUPUToolStripMenuItem_Click(object sender, EventArgs e){
            RapoarteUPU rupu = new RapoarteUPU();
            rupu.Show();
            this.Hide();
        }
        private void rapoarteInternăriToolStripMenuItem_Click(object sender, EventArgs e){
            RapoarteInternari rint = new RapoarteInternari();
            rint.Show();
            this.Hide();
        }
        private void btnConfirmare_Click(object sender, EventArgs e){
            A4();
        }
        private void btnRenuntare_Click(object sender, EventArgs e){
            A3();
        }
        private void btnAdaugare_Click(object sender, EventArgs e){
            A2();
        }
        private void btnModificare_Click(object sender, EventArgs e){
            A5();
        }
        private void btnStergere_Click(object sender, EventArgs e){
            const string msj = "Confirmati ștergerea pacientului?";
            const string Titlu = "Ștergere pacient UPU!";
            var rezultat = MessageBox.Show(msj, Titlu,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A6();
        }
    }
}
