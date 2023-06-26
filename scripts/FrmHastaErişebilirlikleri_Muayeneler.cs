using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    public partial class FrmHastaErişebilirlikleri_Muayeneler : Form
    {
        public string MuayeneTarihi;
        SQLConnection baglan = new SQLConnection();
        public FrmHastaErişebilirlikleri_Muayeneler()
        {
            InitializeComponent();
        }

        private void pcBxAnaEkran_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void pcBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaGirisi HastaMenusu = new FrmHastaGirisi();
            HastaMenusu.idTutan = Convert.ToInt32(lblHastaId.Text);
            HastaMenusu.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblMuayId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            SqlCommand HastaTc = new SqlCommand("select DoktorId,TcNo from Tbl_Hastalar where HastaID=@id", baglan.SQLBaglanti());
            HastaTc.Parameters.AddWithValue("@id", lblHastaId.Text);
            SqlDataReader okuTc = HastaTc.ExecuteReader();
            while (okuTc.Read())
            {
                txtTcNo.Text = okuTc[1].ToString();
                //lblDoktorId.Text = okuTc[0].ToString();
            }
            txtDoktorAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            //SqlCommand DoktorAdi = new SqlCommand("select Unvan+' '+Adi+' '+Soyadi from Tbl_Doktorlar where DoktorID=@id1", baglan.SQLBaglanti());
            //DoktorAdi.Parameters.AddWithValue("@id1", lblDoktorId.Text);
            //SqlDataReader okuDoktorOl = DoktorAdi.ExecuteReader();
            //while (okuDoktorOl.Read())
            //    txtDoktorAd.Text = okuDoktorOl[0].ToString();
            txtMuayeneTarih.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            richMuayeneNedeni.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            baglan.SQLBaglanti().Close();
        }
        private void FrmHastaErişebilirlikleri_Muayeneler_Load(object sender, EventArgs e)
        {
            SqlCommand verileriCek = new SqlCommand(" select m.MuayeneID,hastane.HastaneAdi,p.KlinikAdi,d.Unvan+' '+d.Adi+' '+d.Soyadi as [Doktor Ad Soyad], h.Adi+' '+h.Soyadi as [Hasta Ad Soyad], m.MuayeneTarihi,m.MuayeneNedeni from Tbl_MuayeneGecmisi as m " +
                "join Tbl_Hastane as hastane on m.HastaneId=hastane.HastaneID " +
                "join Tbl_Poliklinikler as p on m.KlinikId=p.KlinikID " +
                "join Tbl_Doktorlar as d on m.DoktorId=d.DoktorID " +
                "join Tbl_Hastalar as h on m.HastaId=h.HastaID where h.HastaID=@id ", baglan.SQLBaglanti());
            verileriCek.Parameters.AddWithValue("@id", lblHastaId.Text);
            SqlDataAdapter da = new SqlDataAdapter(verileriCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand AdiSoyadiGet = new SqlCommand("select 'Hoşgeldin '+Adi+' '+Soyadi from Tbl_Hastalar where HastaID=@f1", baglan.SQLBaglanti());
            AdiSoyadiGet.Parameters.AddWithValue("@f1", lblHastaId.Text);
            SqlDataReader okuHastaAdi = AdiSoyadiGet.ExecuteReader();
            while(okuHastaAdi.Read())
            {
                label6.Text = okuHastaAdi[0].ToString();
            }
            baglan.SQLBaglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil=new SqlCommand("delete From Tbl_MuayeneGecmisi where MuayeneID=@p1",baglan.SQLBaglanti());
            sil.Parameters.AddWithValue("@p1", lblMuayId.Text);
            sil.ExecuteNonQuery();
            baglan.SQLBaglanti().Close();
        }
    }
}
