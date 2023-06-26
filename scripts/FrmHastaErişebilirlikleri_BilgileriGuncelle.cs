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
    public partial class FrmHastaErişebilirlikleri_BilgileriGuncelle : Form
    {
        SQLConnection baglan = new SQLConnection();
        public FrmHastaErişebilirlikleri_BilgileriGuncelle()
        {
            InitializeComponent();
        }
        private void picBxReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaGirisi HastaMenusu = new FrmHastaGirisi();
            HastaMenusu.idTutan = Convert.ToInt32(textBox1.Text);
            HastaMenusu.ShowDialog();
            this.Close();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }
        private void FrmHastaErişebilirlikleri_BilgileriGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand VerileriGetir = new SqlCommand("select Adi,Soyadi,TcNo,DogumTarihi,KanGrubu,Cinsiyet,Telefon,Mail,BabaAdi,AnneAdi,Adres from Tbl_Hastalar " +
                "where HastaID=@hasId", baglan.SQLBaglanti());
            VerileriGetir.Parameters.AddWithValue("@hasId", textBox1.Text);
            SqlDataReader oku = VerileriGetir.ExecuteReader();
            while (oku.Read())
            {
                txtAd.Text = oku[0].ToString();
                txtSoyad.Text = oku[1].ToString();
                mskTc.Text = oku[2].ToString();
                mskBirthd.Text = oku[3].ToString();
                cmbKanGrb.Text = oku[4].ToString();
                cmbCins.Text = oku[5].ToString();
                mksTel.Text = oku[6].ToString();
                txtMail.Text = oku[7].ToString();
                txtBabaAd.Text = oku[8].ToString();
                txtAnneAd.Text = oku[9].ToString();
                richtxtAdres.Text = oku[10].ToString();
            }

            SqlCommand AdveSifreGetir = new SqlCommand("select KullaniciAdi,KullaniciSifre from Tbl_HastaGiris where HastaId=@hasId1", baglan.SQLBaglanti());
            AdveSifreGetir.Parameters.AddWithValue("@hasId1", textBox1.Text);
            SqlDataReader oku2 = AdveSifreGetir.ExecuteReader();
            while (oku2.Read())
            {
                txtKullAd.Text = oku2[0].ToString();
                mskSifre.Text = oku2[1].ToString();
            }
            baglan.SQLBaglanti().Close();
        }  

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand VerileriGuncelle = new SqlCommand("update Tbl_Hastalar set Adi=@ad,Soyadi=@syad,TcNo=@tc,DogumTarihi=@dt,KanGrubu=@kan,Cinsiyet=@cins," +
                     "Telefon=@tel,Mail=@mail,BabaAdi=@babaAd,AnneAdi=@anneAd,Adres=@adres where HastaID=@id", baglan.SQLBaglanti());
                VerileriGuncelle.Parameters.AddWithValue("@id", textBox1.Text);
                VerileriGuncelle.Parameters.AddWithValue("@ad", txtAd.Text);
                VerileriGuncelle.Parameters.AddWithValue("@syad", txtSoyad.Text);
                VerileriGuncelle.Parameters.AddWithValue("@tc", mskTc.Text);
                VerileriGuncelle.Parameters.AddWithValue("@dt", mskBirthd.Text);
                VerileriGuncelle.Parameters.AddWithValue("@kan", cmbKanGrb.Text);
                VerileriGuncelle.Parameters.AddWithValue("@cins", cmbCins.Text);
                VerileriGuncelle.Parameters.AddWithValue("@tel", mksTel.Text);
                VerileriGuncelle.Parameters.AddWithValue("@mail", txtMail.Text);
                VerileriGuncelle.Parameters.AddWithValue("@babaAd", txtBabaAd.Text);
                VerileriGuncelle.Parameters.AddWithValue("@anneAd", txtAnneAd.Text);
                VerileriGuncelle.Parameters.AddWithValue("@adres", richtxtAdres.Text);
                VerileriGuncelle.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Kısım Hatası");
                throw;
            }

            try
            {
                SqlCommand VerileriGuncelle2 = new SqlCommand("update Tbl_HastaGiris set KullaniciAdi=@kAdi,KullaniciSifre=@sifre where HastaId=@id1", baglan.SQLBaglanti());
                VerileriGuncelle2.Parameters.AddWithValue("@id1", textBox1.Text);
                VerileriGuncelle2.Parameters.AddWithValue("@kAdi", txtKullAd.Text);
                VerileriGuncelle2.Parameters.AddWithValue("@sifre", mskSifre.Text);
                VerileriGuncelle2.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hesap Kısım Hatası");
                throw;
            }
            
            baglan.SQLBaglanti().Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                mskSifre.UseSystemPasswordChar = false;
            }
            else
                mskSifre.UseSystemPasswordChar = true;
        }
    }


}
