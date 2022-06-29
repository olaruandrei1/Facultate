using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect{
    public partial class Internari : Form{
        public Internari(){
            InitializeComponent();
        }
        private void Internari_Load(object sender, EventArgs e){
            this.sectiiTableAdapter.Fill(this.bazadedate.Sectii);
            A1();
            txtIdInternare.Enabled = false;
        }
        private void A1(){
            this.internariTableAdapter.Fill(this.bazadedate.Internari);
            //Configurez Poza cardului de sanatate;
            pozacardsanatate.SizeMode = PictureBoxSizeMode.StretchImage;
            //Initiez protectia Gridului;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            A3();
        }
        private void A2(){
            //Configurez butoanele;
            configureazaButoane(false);
            //Dezleg controalele de la Panelul Principal
            legareControale(false);
            //"Elimin" protectia controalelor din Panel;
            protectiePanel(false);
            //Modific lblOperatiune pentru adaugare;
            lblOperatiune.Text = "ADAUG";
            //Pun focusul pe primul camp de completare;
            txtNumePacient.Focus();
            //Pregatesc campurile pentru introducerea datelor;
            golireCampuri();
        }
        private void A3(){
            //Initializez label-ul Operatiune drept "null";
            lblOperatiune.Text = "";
            //Configurez butoanele;
            configureazaButoane(true);
            //"Pun" protectia asupra Panelului Principal;
            protectiePanel(true);
            //leg controalele;
            legareControale(true);
        }
        private void A4(){
            if (lblOperatiune.Text == "ADAUG"){
                if (!validareaCampurilor()) return;//conditia de a completa campurile;
                adauga_internare();//Adaug internarea;
                golireCampuri();//Pregatesc campurile pentru urmatoarea;
                txtNumePacient.Focus();//Pun focus pe primul camp;
                refresh_grid(internariBindingSource.Position);//Am dat refresh la grid, pentru a vizualiza in timp real adaugarea internarii;
            }
            else if (lblOperatiune.Text == "MODIFIC"){
                if (!validareaCampurilor()) return;//conditia de a completa campurile;
                modific_internare();//Modific internarea;
                refresh_grid(internariBindingSource.Position);//Am dat refresh la grid, pentru a vizualiza in timp real modificarea internarii;
                A3();
            }else{
                MessageBox.Show("Operatiunea a eșuat. Vă rugăm să încercați din nou!");
            }
        }
        private void A6(){
            if (lblOperatiune.Text == "") return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                txtpozacard.Text = openFileDialog1.FileName;
                pozacardsanatate.ImageLocation = txtpozacard.Text;
            }
        }
        private void A7(){
            //Configurez butoanele;
            configureazaButoane(false);
            //Dezleg controalele de la Panel;
            legareControale(false);
            //"Elimin" protectia controalelor de la Panelul Principal;
            protectiePanel(false);
            //Initiez label Operatiunii cu "MODIFIC";
            lblOperatiune.Text = "MODIFIC";
            //Pun focus pe primul camp de completare;
            txtNumePacient.Focus();
        }
        private void A8(){
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = internariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;//88->92 conectarea la baza de date + definirea variabilelor in uz;
            cmd.CommandText = "DELETE FROM Internari WHERE IdInternare = " + txtIdInternare.Text;//Comanda de tip SQL pentru stergerea Internarii;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();//Executia comenzii de stergere
            con.Close();
            refresh_grid(internariBindingSource.Position);//Am dat refresh la grid, pentru a vizualiza in timp real stergerea internarii;
        }
        private void configureazaButoane(bool v){
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Visible = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void legareControale(bool v){
            if (v){
                txtIdInternare.DataBindings.Add("Text", internariBindingSource, "IdInternare");
                txtNumePacient.DataBindings.Add("Text", internariBindingSource, "NumePacient");
                txtEpicriza.DataBindings.Add("Text", internariBindingSource, "Epicriza");
                datainternare.DataBindings.Add("Value", internariBindingSource, "DataInternarii");
                dataexternare.DataBindings.Add("Value", internariBindingSource, "DataExternarii");
                comboSectie.DataBindings.Add("Text", internariBindingSource, "Sectie");
                pozacardsanatate.DataBindings.Add("ImageLocation", internariBindingSource, "PozaCard");
            }else{
                txtIdInternare.DataBindings.Clear();
                txtNumePacient.DataBindings.Clear();
                datainternare.DataBindings.Clear();
                comboSectie.DataBindings.Clear();
                dataexternare.DataBindings.Clear();
                pozacardsanatate.DataBindings.Clear();
                txtEpicriza.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v){
            txtNumePacient.ReadOnly = v;
            txtEpicriza.ReadOnly = v;
            comboSectie.Enabled = !v;
            datainternare.Enabled = !v;
            dataexternare.Enabled = !v;
            txtpozacard.ReadOnly = v;
        }
        private void golireCampuri(){
            txtNumePacient.Text = "";
            txtIdInternare.Text = "";
            txtEpicriza.Text = "";
            txtpozacard.Text = "";
            pozacardsanatate.ImageLocation = "";
        }
        private bool validareaCampurilor(){
            if(txtNumePacient.Text == ""){
                MessageBox.Show("Completați numele și prenumele pacientului");
                txtNumePacient.Focus();
                return false;
            }
            if(txtEpicriza.Text == ""){
                MessageBox.Show("Completați Epicriza");
                txtEpicriza.Focus();
                return false;
            }
            if(comboSectie.SelectedIndex == -1){
                MessageBox.Show("Completați secția unde pacientul se internează!");
                comboSectie.Focus();
                return false;
            }
            return true;
        }
        private void adauga_internare(){
            string ListaAccess;//definesc o lista cu coloanele din Access
            string ListaText;//definesc o lista cu campurile text 
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = internariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;//realizez conectiunea la baza de date
            ListaAccess = "NumePacient, Sectie, DataInternarii, DataExternarii, Epicriza, PozaCard";
            ListaText = "'"  + txtNumePacient.Text + "'" +
                        ",'" + comboSectie.SelectedValue + "'" +
                        ",'" + datainternare.Value + "'" +
                        ",'" + dataexternare.Value + "'" +
                        ",'" + txtEpicriza.Text + "'" +
                        ",'" + txtpozacard.Text + "'";
            cmd.CommandText = "INSERT INTO Internari(" + ListaAccess + ") " + "SELECT " + ListaText;//comanda de tip SQL pentru Adaugarea in ACCESS
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();//Executarea comenzii
            con.Close();
            ocupare_pat();//functia pentru ocuparea patului
        }
        private void ocupare_pat(){//REalizez o functie ce scade cu "-1" din numarul Actual de paturi disponibile sectiei selectate
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = internariTableAdapter.Connection.ConnectionString;
            cmd.Connection= con;//am realizat conexiunea la baza de date
            cmd.CommandText = "UPDATE Sectii SET NumarActualPaturi = NumarActualPaturi -1 WHERE DSectie ='" + comboSectie.Text +"'";//comanda SQL pentru a decrementa numarul Actual de paturi pentru Sectia respectiva
            con.Open();
            cmd.ExecuteNonQuery();//executia
            con.Close();

        }
        private void refresh_grid(int p){
            internariTableAdapter.Fill(bazadedate.Internari);
            internariBindingSource.Position = p;
        }
        private void modific_internare(){
            string lista;//initiez o lista, ce coreleaza campurile text cu coloanele din Access
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = internariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;//realizez conectiunea
            lista = "NumePacient ='" + txtNumePacient + "'," +
                    "Sectie ='" + comboSectie.SelectedValue + "'," +
                    "DataInternarii ='" + datainternare.Value + "'," +
                    "DataExternarii ='" + dataexternare.Value + "'," +
                    "Epicriza ='" + txtEpicriza.Text + "'," +
                    "PozaCard ='" + txtpozacard.Text + "'";
            cmd.CommandText = "UPDATE Internari SET " + lista + " WHERE IdInternare=" + txtIdInternare.Text;//Comanda de tip SQL ce realizeaza modificarea in Access;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void btnAdaugare_Click(object sender, EventArgs e){
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e){
            A7();
        }
        private void btnStergere_Click(object sender, EventArgs e){
            const string Mesaj = "Confirmati stergerea internarii?";
            const string Titlu = "Stergere internare";
            var rez = MessageBox.Show(Mesaj, Titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rez == DialogResult.No) return;
            A8();
        }
        private void btnConfirmare_Click(object sender, EventArgs e){
            A4();
        }
        private void btnRenuntare_Click(object sender, EventArgs e){
            A3();
        }
        private void txtpozacard_MouseDoubleClick(object sender, EventArgs e){
            A6();
        }
        private void primiriUrgențeToolStripMenuItem_Click(object sender, EventArgs e){
            Pacienti pacienti = new Pacienti();
            pacienti.Show();
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
    }
}
