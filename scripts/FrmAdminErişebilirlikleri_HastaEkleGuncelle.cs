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
    public partial class FrmAdminErişebilirlikleri_HastaEkleGuncelle : Form
    {
        public FrmAdminErişebilirlikleri_HastaEkleGuncelle()
        {
            InitializeComponent();
        }

        SQLConnection baglanti = new SQLConnection();
        HastaIdCek IdAl = new HastaIdCek();

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select HastaID,h.Adi Ad,h.Soyadi Soyad,h.TcNo,h.DogumTarihi,h.KanGrubu,h.Cinsiyet,h.yas,h.Telefon,h.Mail,h.BabaAdi,h.AnneAdi,h.Adres from Tbl_Hastalar as h ", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtMail.Clear();
            txtDogmT.Clear();
            txtBabaAd.Clear();
            txtAnneAd.Clear();
            cmbCinsiyet.Text = "";
            cmbKan.Text = "";
            richBxAdres.Clear();
            mskTc.Clear();
            mskTel.Clear();
            txtKullaniciAdi.Clear();
            mskSifre.Clear();
        }

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Hasta HastaEkleGuncelle = new FrmAdminErişebilirlikleri_Hasta();
            HastaEkleGuncelle.lblAdminID.Text = lblAdminId.Text;
            HastaEkleGuncelle.ShowDialog();
            this.Close();
        }

        private void picBxGirisEkrani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmAdminErişebilirlikleri_HastaEkleGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label14.Text = oku[0].ToString();
            }
            ListeleData();
            baglanti.SQLBaglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblHastaId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtDogmT.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbKan.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtYas.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtBabaAd.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtAnneAd.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            richBxAdres.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();

            SqlCommand cek = new SqlCommand("select HastaId,KullaniciAdi,KullaniciSifre from Tbl_HastaGiris where HastaId=@i1", baglanti.SQLBaglanti());
            cek.Parameters.AddWithValue("@i1", lblHastaId.Text);
            SqlDataReader oku = cek.ExecuteReader();
            while(oku.Read())
            {
                txtKullaniciAdi.Text = oku[1].ToString();
                mskSifre.Text = oku[2].ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (Adi,Soyadi,TcNo,DogumTarihi,KanGrubu,Cinsiyet,Yas,Telefon,Mail,BabaAdi,AnneAdi,Adres)" +
                "values (@u1,@u2,@u3,@u4,@u5,@u6,@u7,@u8,@u9,@u10,@u11,@u12)", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@u1", txtAd.Text);
            komut.Parameters.AddWithValue("@u2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@u3", mskTc.Text);
            komut.Parameters.AddWithValue("@u4", txtDogmT.Text);
            komut.Parameters.AddWithValue("@u5", cmbKan.Text);
            komut.Parameters.AddWithValue("@u6", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@u7", txtYas.Text);
            komut.Parameters.AddWithValue("@u8", mskTel.Text);
            komut.Parameters.AddWithValue("@u9", txtMail.Text);
            komut.Parameters.AddWithValue("@u10", txtBabaAd.Text);
            komut.Parameters.AddWithValue("@u11", txtAnneAd.Text);
            komut.Parameters.AddWithValue("@u12", richBxAdres.Text);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("insert into Tbl_HastaGiris (HastaId,KullaniciAdi,KullaniciSifre) values (@y1,@y2,@y3)", baglanti.SQLBaglanti());
            komut2.Parameters.AddWithValue("@y1", IdAl.HastaIDCek());
            komut2.Parameters.AddWithValue("@y2", txtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@y3", mskSifre.Text);
            komut2.ExecuteNonQuery();

            MessageBox.Show("Ekleme Başarılı");
            ListeleData();
        }

        private void btnTemiz_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set Adi=@u1,Soyadi=@u2,TcNo=@u3,DogumTarihi=@u4,KanGrubu=@u5,Cinsiyet=@u6,Yas=@u7,Telefon=@u8,Mail=@u9,BabaAdi=@u10,AnneAdi=@u11,Adres=@u12 where HastaID=@u0", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@u0", lblHastaId.Text);
            komut.Parameters.AddWithValue("@u1", txtAd.Text);
            komut.Parameters.AddWithValue("@u2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@u3", mskTc.Text);
            komut.Parameters.AddWithValue("@u4", txtDogmT.Text);
            komut.Parameters.AddWithValue("@u5", cmbKan.Text);
            komut.Parameters.AddWithValue("@u6", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@u7", txtYas.Text);
            komut.Parameters.AddWithValue("@u8", mskTel.Text);
            komut.Parameters.AddWithValue("@u9", txtMail.Text);
            komut.Parameters.AddWithValue("@u10", txtBabaAd.Text);
            komut.Parameters.AddWithValue("@u11", txtAnneAd.Text);
            komut.Parameters.AddWithValue("@u12", richBxAdres.Text);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update Tbl_HastaGiris set KullaniciAdi=@u13, KullaniciSifre=@u14 where HastaId=@u15", baglanti.SQLBaglanti());
            komut2.Parameters.AddWithValue("@u15", lblHastaId.Text);
            komut2.Parameters.AddWithValue("@u13", txtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@u14", mskSifre.Text);
            komut2.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");
            ListeleData();
        }
    }
}
