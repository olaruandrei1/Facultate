using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;

namespace Proiect{
    public partial class RapoarteInternari : Form{
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\olaru\\Desktop\\ProiectMPP2\\Resurse\\HOS2.mdb");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int variabilaLinii;
        public RapoarteInternari(){
            InitializeComponent();
        }
        private void filtru(){
            try{internariBindingSource1.Filter = "Sectie = '" + comboBox1.Text + "'";}
            catch{ }
        }
        private void RapoarteInternari_Load(object sender, EventArgs e){
            this.queryIntPatTableAdapter.Fill(this.bazadedate.QueryIntPat);
            this.internariTableAdapter.Fill(this.bazadedate.Internari);
            this.sectiiTableAdapter.Fill(this.bazadedate.Sectii);
            filtru();
            chart();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            filtru();
        }
        
        private void chart(){
            variabilaLinii = bazadedate.QueryIntPat.Count;
            int[] yval = new int[variabilaLinii];
            string[] xval = new string[variabilaLinii];
            int i = 0;
            foreach (DataRowView r in queryIntPatBindingSource){
                xval[i] = r["Sectie"].ToString(); 
                 yval[i] = Convert.ToInt32(r["NumarActualPaturi"].ToString()); 
                 i++;
            }
            chartPat.Series[0].Points.DataBindXY(xval, yval);
            chartPat.Series[0].Name = "Situație Paturi Sectii";
            chartPat.Series[0].ChartType = SeriesChartType.Column;
            chartPat.Invalidate();
        }
        
        private void btnRaport_Click(object sender, EventArgs e){
            RaportrdlcInternari intrdlc = new RaportrdlcInternari();
            intrdlc.Show();
        }
               
        private void btnRaportPaturi_Click(object sender, EventArgs e){
            RaportrdlcInternariPaturi intpatrdlc = new RaportrdlcInternariPaturi();
            intpatrdlc.Show();
        }

        private void btnFiltruData_Click(object sender, EventArgs e){
            internariDataTableAdapter.Fill(bazadedate.InternariData, dateTimePicker1.Value, dateTimePicker2.Value);
        }
        private void primiriUrgențeToolStripMenuItem_Click_1(object sender, EventArgs e){
            Pacienti UPU = new Pacienti();
            UPU.Show();
            this.Hide();
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
            RapoarteInternari rrupu = new RapoarteInternari();
            rrupu.Show();
            this.Hide();
        }
    }
}
