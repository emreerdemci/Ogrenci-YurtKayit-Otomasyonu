using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmGelirRapor : Form
    {
        public FrmGelirRapor()
        {
            InitializeComponent();
        }

        private void FrmGelirRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Proje_YurtOtomasyonuDataSet1.Kasa' table. You can move, or remove it, as needed.
            this.KasaTableAdapter.Fill(this.Proje_YurtOtomasyonuDataSet1.Kasa);

            this.reportViewer1.RefreshReport();
        }
    }
}
