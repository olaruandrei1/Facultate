using System;

using System.Data;
using System.Windows.Forms;

namespace Proiect{
    public partial class RaportrdlcUPU : Form{
        public RaportrdlcUPU(){
            InitializeComponent();
        }
        private void RaportParasireUPU_Load(object sender, EventArgs e){
            // TODO: This line of code loads data into the 'bazadedate.QueryUPU' table. You can move, or remove it, as needed.
            this.queryUPUTableAdapter.Fill(this.bazadedate.QueryUPU);
            this.reportViewer1.RefreshReport();
        }
    }
}
