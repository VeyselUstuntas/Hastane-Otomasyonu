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
    public partial class FrmDoktorErişebilirlikleri_HastaEkle : Form
    {
        public FrmDoktorErişebilirlikleri_HastaEkle()
        {
            InitializeComponent();
        }
        SQLConnection baglanti = new SQLConnection();
        HastaIdCek IdAl = new HastaIdCek();
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
                komutHasBil.Parameters.AddWithValue("@d4", txtDogumT.Text);
                komutHasBil.Parameters.AddWithValue("@d5", cmbKanGrb.Text);
                komutHasBil.Parameters.AddWithValue("@d6", cmbCins.Text);
                komutHasBil.Parameters.AddWithValue("@d7", mksTel.Text);
                komutHasBil.Parameters.AddWithValue("@d8", txtMail.Text);
                komutHasBil.Parameters.AddWithValue("@d9", txtBabaAd.Text);
                komutHasBil.Parameters.AddWithValue("@d10", txtAnneAd.Text);
                komutHasBil.Parameters.AddWithValue("@d11", richtxtAdres.Text);
                komutHasBil.ExecuteNonQuery();

                //SqlCommand bilgileriTamala = new SqlCommand("update Tbl_Hastalar set HastaneId=@h1, KlinikId=@h2, DoktorId=@h3 where ");
                //bilgileriTamala.Parameters.AddWithValue("@h1", txtHasID.Text);
                //bilgileriTamala.Parameters.AddWithValue("@h2", txtKlinikId.Text);
                //bilgileriTamala.Parameters.AddWithValue("@h3", txtDoktorID.Text);
                //bilgileriTamala.ExecuteNonQuery();
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
                MessageBox.Show("Hasta Kaydı Oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                throw;
            }
        }

        private void picBxReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoktorErişebilirlikleri_Menu DoktorMenusu = new FrmDoktorErişebilirlikleri_Menu();
            DoktorMenusu.txtDoktorId.Text = txtDoktorID.Text;
            DoktorMenusu.YoneticiId = Convert.ToInt32(txtYoneticiId.Text);
            DoktorMenusu.ShowDialog();
            this.Close();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmDoktorErişebilirlikleri_HastaEkle_Load(object sender, EventArgs e)
        {
            SqlCommand hastaneIdveKlinikId = new SqlCommand("select HastaneId, KlinikId from Tbl_Doktorlar where DoktorID=@dokID", baglanti.SQLBaglanti());
            hastaneIdveKlinikId.Parameters.AddWithValue("@dokID", txtDoktorID.Text);
            SqlDataReader okuID = hastaneIdveKlinikId.ExecuteReader();
            while (okuID.Read())
            {
                txtHasID.Text = okuID[0].ToString();
                txtKlinikId.Text = okuID[1].ToString();
            }
        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                mskSifre.UseSystemPasswordChar = false;
            else
                mskSifre.UseSystemPasswordChar = true;
        }
    }
}
