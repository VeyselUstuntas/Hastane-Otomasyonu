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
    public partial class FrmDoktorErişebilirlikleri_Tahliller : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmDoktorErişebilirlikleri_Tahliller()
        {
            InitializeComponent();
        }
        public object HastaId;
        private void ListeleData()
        {
            SqlCommand listele = new SqlCommand("select t.HastaId,h.Adi+' '+ h.Soyadi as [Hasta Ad Soyad],TahlilAdi,TahlilDurumu,TahlilDegeri,TahlilTarihi from Tbl_Tahliller as t" +
                "join Tbl_Hastalar as h on t.HastaId=h.HastaID" +
                " where t.DoktorId=@k1 and h.HastaID=@k2", baglanti.SQLBaglanti());
            listele.Parameters.AddWithValue("@k1", lblDoktorId.Text);
            listele.Parameters.AddWithValue("@k2", lblHastaId.Text);

            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ListeleTahlil()
        {
            SqlCommand komut = new SqlCommand("select t.HastaId,TahlilAdi,TahlilDurumu,TahlilDegeri,TahlilTarihi from Tbl_Tahliller as t" +
                " where t.DoktorId = @k1 and t.HastaId = @k2", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@k1", lblDoktorId.Text);
            komut.Parameters.AddWithValue("@k2", lblHastaId.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            FrmDoktorErişebilirlikleri_DoktorHastaları DoktorHastalari = new FrmDoktorErişebilirlikleri_DoktorHastaları();
            this.Hide();
            DoktorHastalari.txtDoktorId.Text = lblDoktorId.Text;
            DoktorHastalari.txtYoneticiId.Text = lblYoneticiId.Text;
            DoktorHastalari.ShowDialog();
            this.Close();
        }

        private void FrmDoktorErişebilirlikleri_Tahliller_Load(object sender, EventArgs e)
        {
            lblHastaId.Text = HastaId.ToString();
            SqlCommand doktoradi = new SqlCommand("select 'Hoşgeldiniz '+Unvan+' '+Adi+' '+Soyadi from Tbl_Doktorlar where DoktorID=@id", baglanti.SQLBaglanti());
            doktoradi.Parameters.AddWithValue("@id", lblDoktorId.Text);
            SqlDataReader okuad = doktoradi.ExecuteReader();
            while (okuad.Read())
            {
                lblDoktorad.Text = okuad[0].ToString();
            }
            
            ListeleTahlil();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void txtTahlilKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Tahliller (HastaneId,KlinikId, DoktorId, MuayeneId,HastaId,TahlilAdi,TahlilDurumu,TahlilDegeri,TahlilTarihi)  " +
                "values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9 )", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@d1", lblHastnId.Text);
            komut.Parameters.AddWithValue("@d2", lblKlinikıd.Text);
            komut.Parameters.AddWithValue("@d3", lblDoktorId.Text);
            komut.Parameters.AddWithValue("@d4", lblMuayeneId.Text);
            komut.Parameters.AddWithValue("@d5", lblHastaId.Text);
            komut.Parameters.AddWithValue("@d6", txtTahAdı.Text);
            komut.Parameters.AddWithValue("@d7", txtTahDurum.Text);
            komut.Parameters.AddWithValue("@d8", txtTahDeger.Text);
            komut.Parameters.AddWithValue("@d9", txtTahTarih.Text);
            komut.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            ListeleTahlil();
            MessageBox.Show("Ekleme Başarılı");

        }
    }
}
