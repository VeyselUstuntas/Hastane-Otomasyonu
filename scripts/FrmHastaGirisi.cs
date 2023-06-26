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
    public partial class FrmHastaGirisi : Form
    {
        public FrmHastaGirisi()
        {
            InitializeComponent();
        }
        SQLConnection baglan = new SQLConnection();
        public int idTutan;

        private void FrmHastaGirisi_Load(object sender, EventArgs e)
        {
            //label2.Text = idTutan.ToString();
            FrmHastaGirisEkrani HastaGirisEkrani1 = new FrmHastaGirisEkrani();
            SqlCommand ıdAl=new SqlCommand("select HastaId from Tbl_HastaGiris where KullaniciAdi=@kulAdi and KullaniciSifre=@kSifre", baglan.SQLBaglanti());
            ıdAl.Parameters.AddWithValue("@kulAdi", HastaGirisEkrani1.txtKullaniciAdi.Text);
            ıdAl.Parameters.AddWithValue("@kSifre", HastaGirisEkrani1.txtSifre.Text);
            SqlDataReader oku2 = ıdAl.ExecuteReader();
            while(oku2.Read())
            {
                idTutan = (int)oku2[0];
            }
            label2.Text = idTutan.ToString();
            SqlCommand komut = new SqlCommand("select 'Hoşgeldin '+Adi+' '+Soyadi from Tbl_Hastalar where HastaID=@id", baglan.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", label2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label1.Text = oku[0].ToString();
            }
        }
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaKaydı YeniKayit = new FrmHastaKaydı();
            YeniKayit.ShowDialog();
            this.Close();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        public void btnRandevu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaErişebilirlikleri_Randevu HastaRandevuEkr = new FrmHastaErişebilirlikleri_Randevu();
            SqlCommand HastaIdveKadoku = new SqlCommand("select HastaID,Adi+' ' +Soyadi from Tbl_Hastalar where HastaID=@id", baglan.SQLBaglanti());
            HastaIdveKadoku.Parameters.AddWithValue("@id", label2.Text);
            SqlDataReader okuAdiId = HastaIdveKadoku.ExecuteReader();
            while(okuAdiId.Read())
            {
                HastaRandevuEkr.label7.Text = okuAdiId[1].ToString();
                HastaRandevuEkr.textBox1.Text = okuAdiId[0].ToString();
            }
            baglan.SQLBaglanti().Close();
            HastaRandevuEkr.ShowDialog();
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaErişebilirlikleri_BilgileriGuncelle BilgileriGuncelle=new FrmHastaErişebilirlikleri_BilgileriGuncelle();
            BilgileriGuncelle.textBox1.Text = label2.Text;
            SqlCommand komutAdiGetir = new SqlCommand("select Adi+' '+Soyadi from Tbl_Hastalar where HastaID=@hasId", baglan.SQLBaglanti());
            komutAdiGetir.Parameters.AddWithValue("@hasId", label2.Text);
            SqlDataReader okuAdiSoyadi = komutAdiGetir.ExecuteReader();
            while(okuAdiSoyadi.Read())
            {
                BilgileriGuncelle.label15.Text = okuAdiSoyadi[0].ToString();
            }
            //BilgileriGuncelle.label15.Text = label2.Text;
            BilgileriGuncelle.ShowDialog();
            this.Close();
        }

        private void btnTahlil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaErişebilirlikleri_TahlilSonuclari TahlilSonuclari = new FrmHastaErişebilirlikleri_TahlilSonuclari();
            TahlilSonuclari.lblHastaId.Text = label2.Text;
            TahlilSonuclari.ShowDialog();
            this.Close();
        }

        private void btnMuaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaErişebilirlikleri_Muayeneler Muayeneler=new FrmHastaErişebilirlikleri_Muayeneler();
            Muayeneler.lblHastaId.Text = label2.Text;
            Muayeneler.ShowDialog();
            this.Close();

        }

        private void btnIlac_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaErişebilirlikleri_Ilaclar HastaIlacEkrani = new FrmHastaErişebilirlikleri_Ilaclar();
            HastaIlacEkrani.lblHastaId.Text = label2.Text;
            HastaIlacEkrani.ShowDialog();
            this.Close();
        }

    }
}
