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
    public partial class FrmHastaKaydı : Form
    {
        SQLConnection baglanti = new SQLConnection();
        HastaIdCek IdAl = new HastaIdCek();

        public FrmHastaKaydı()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                mskSifre.UseSystemPasswordChar = false;
            else
                mskSifre.UseSystemPasswordChar = true;
        }

        private void picBxReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaKayit_ve_Giris HastaGirisi = new FrmHastaKayit_ve_Giris();
            HastaGirisi.ShowDialog();
            this.Close();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutHasBil = new SqlCommand("insert into Tbl_Hastalar([Adi],[Soyadi],[TcNo],[DogumTarihi],[KanGrubu],[Cinsiyet],[Telefon],[Mail],[BabaAdi],[AnneAdi],[Adres])" +
                "values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)", baglanti.SQLBaglanti());
                //hata bigileri textboxlarda alınmak üzere sqlcommand ile alınıyor

                komutHasBil.Parameters.AddWithValue("@d1", txtAd.Text);
                komutHasBil.Parameters.AddWithValue("@d2", txtSoyad.Text);
                komutHasBil.Parameters.AddWithValue("@d3", mskTc.Text);
                komutHasBil.Parameters.AddWithValue("@d4", mskBirthd.Text);
                komutHasBil.Parameters.AddWithValue("@d5", cmbKanGrb.Text);
                komutHasBil.Parameters.AddWithValue("@d6", cmbCins.Text);
                komutHasBil.Parameters.AddWithValue("@d7", mksTel.Text);
                komutHasBil.Parameters.AddWithValue("@d8", txtMail.Text);
                komutHasBil.Parameters.AddWithValue("@d9", txtBabaAd.Text);
                komutHasBil.Parameters.AddWithValue("@d10", txtAnneAd.Text);
                komutHasBil.Parameters.AddWithValue("@d11", richtxtAdres.Text);
                komutHasBil.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Oluşturuldu");
                baglanti.SQLBaglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata...Kayıt Oluşturulamadı");
            }

            try
            {
                SqlCommand komutHesapBil = new SqlCommand("insert into Tbl_HastaGiris (HastaId,KullaniciAdi,KullaniciSifre)" +
                    "values(@k0,@k1,@k2)", baglanti.SQLBaglanti());
                komutHesapBil.Parameters.AddWithValue("@k0", Convert.ToInt32(IdAl.HastaIDCek()));
                komutHesapBil.Parameters.AddWithValue("@k1", txtKullAd.Text);
                komutHesapBil.Parameters.AddWithValue("@k2", mskSifre.Text);
                komutHesapBil.ExecuteNonQuery();
                baglanti.SQLBaglanti().Close();
                MessageBox.Show("Hesabınıza Giriş Yapabilirsiniz");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                throw;
            }

        }
    }
}
