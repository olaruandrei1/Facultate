using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Windows.Forms;

namespace Proiect{
    public partial class RapoarteUPU : Form{
        private int variabilaLinii;
        public RapoarteUPU(){
            InitializeComponent();
        }
        private void RapoarteUPU_Load(object sender, EventArgs e){
            this.queryUPUTableAdapter.Fill(this.bazadedate.QueryUPU);
            this.pacientiTableAdapter.Fill(this.bazadedate.Pacienti);
            this.codUrgentaTableAdapter.Fill(this.bazadedate.CodUrgenta);
            filtruCombo();
            chart();
        }
        private void primiriUrgențeToolStripMenuItem_Click(object sender, EventArgs e){
            Pacienti pac = new Pacienti();
            pac.Show();
            this.Hide();
        }
        private void internăriToolStripMenuItem_Click(object sender, EventArgs e){
            Internari intern = new Internari();
            intern.Show();
            this.Hide();
        }
        private void rapoarteInternăriToolStripMenuItem_Click(object sender, EventArgs e){
            RapoarteInternari rint = new RapoarteInternari();
            rint.Show();
            this.Hide();
        }
        private void filtruCombo(){
            try { pacientiBindingSource.Filter = "CodUrgenta= '" + comboCod.Text + "'"; }
            catch { };
        }

        private void chart(){
            variabilaLinii = bazadedate.QueryUPU.Count;
            int[] yval = new int[variabilaLinii];
            string [] xval = new string[variabilaLinii];
            int i = 0;
            foreach (DataRowView r in queryUPUBindingSource){
                xval[i] = r["CodUrgenta"].ToString();
                yval[i] = Convert.ToInt32(r["TotalIntrari"].ToString());
                i++;
            }
            chartCod.Series[0].Points.DataBindXY(xval, yval);
            chartCod.Series[0].Name = "Situație Coduri UPU";
            chartCod.Series[0].ChartType = SeriesChartType.Column;
            chartCod.Invalidate();  
        }
        private void btnRaport_Click(object sender, EventArgs e){
            RaportrdlcUPU upurdlc = new RaportrdlcUPU();
            upurdlc.Show();
        }

        private void comboCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtruCombo();
        }
    }
}
