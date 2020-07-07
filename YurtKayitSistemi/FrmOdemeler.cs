using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ogrid,OgrAd,OgrSoyad,OgrKalanBorc From Borclar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            TxtKalan.Text = kalan;
            TxtOgrid.Text = id;
        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            ////Ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt32(TxtOdenen.Text);
            kalan = Convert.ToInt32(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            //Yeni Tutarı veri tabanına kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set ogrkalanborc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ogrid,OgrAd,OgrSoyad,OgrKalanBorc From Borclar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Kasa Tablosuna Ekleme Yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar)values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
