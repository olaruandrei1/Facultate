using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect { 

    public partial class Conectare : Form{
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\olaru\\Desktop\\Facultate\\Medii de Proiectare\\Proiect\\Resurse\\HOS2.mdb");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Conectare(){
            InitializeComponent();
        }

        private void btnConectare_Click(object sender, EventArgs e){
            if (con.State == ConnectionState.Closed){
                con.Open();
            }
            string conectare = "SELECT * FROM Utilizatori WHERE NumeUtilizator ='" + txtNumeUtilizator.Text + "' AND ParolaUtilizator ='" + txtParola.Text + "'";
            cmd = new OleDbCommand(conectare, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                Pacienti pacienti = new Pacienti();
                pacienti.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credențialele introduse sunt incorecte, vă rugăm să reîncercați!", "Conectare Eșuată!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeUtilizator.Text = "";
                txtParola.Text = "";
                txtNumeUtilizator.Focus();
            }
        }
    }
}
