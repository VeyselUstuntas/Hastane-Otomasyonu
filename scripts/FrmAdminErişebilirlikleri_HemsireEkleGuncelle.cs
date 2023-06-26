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
    public partial class FrmAdminErişebilirlikleri_HemsireEkleGuncelle : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_HemsireEkleGuncelle()
        {
            InitializeComponent();
        }

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select hem.HemsireID,h.HastaneAdi,p.KlinikAdi,hem.Adi,hem.Soyadi ,hem.TcNo,hem.DogumTarihi,hem.Cinsiyet,hem.Telefon,hem.Adres from Tbl_Hemsireler as hem " +
                "join Tbl_Hastane as h on hem.HasteneId=h.HastaneID " +
                "join Tbl_Poliklinikler as p on p.KlinikID=hem.KlinikId ", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Hemsire HemsireBilgiEkrani = new FrmAdminErişebilirlikleri_Hemsire();
            HemsireBilgiEkrani.lblAdminId.Text = lblAdminId.Text;
            HemsireBilgiEkrani.ShowDialog();
            this.Close();
        }

        private void picBxGirisEkrani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmAdminErişebilirlikleri_HemsireEkleGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label11.Text = oku[0].ToString();
            }

            SqlCommand Listele = new SqlCommand("select hem.HemsireID,h.HastaneAdi,p.KlinikAdi,hem.Adi,hem.Soyadi ,hem.TcNo,hem.DogumTarihi,hem.Cinsiyet,hem.Telefon,hem.Adres from Tbl_Hemsireler as hem " +
                "join Tbl_Hastane as h on hem.HasteneId=h.HastaneID " +
                "join Tbl_Poliklinikler as p on p.KlinikID=hem.KlinikId ", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand HastaneCek = new SqlCommand("select HastaneID,HastaneAdi from Tbl_Hastane", baglanti.SQLBaglanti());
            SqlDataReader okuHastane = HastaneCek.ExecuteReader();
            while (okuHastane.Read())
            {
                cmbHastane.Items.Add(okuHastane[1]).ToString();
            }

            SqlCommand komut3 = new SqlCommand("select HastaneID from Tbl_Hastane where HastaneAdi=@b1", baglanti.SQLBaglanti());
            komut3.Parameters.AddWithValue("@b1", cmbHastane.Text);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblHastaneId.Text = oku3[0].ToString();
            }
            baglanti.SQLBaglanti().Close();


            baglanti.SQLBaglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hemsireler (HasteneId,KlinikId,Adi,Soyadi,TcNo,Telefon,Cinsiyet,DogumTarihi,Adres) values (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9)", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@v1",lblHastaneId.Text);
            komut.Parameters.AddWithValue("@v2", lblKlinikId.Text);
            komut.Parameters.AddWithValue("@v3", txtAd.Text);
            komut.Parameters.AddWithValue("@v4", txtSoyad.Text);
            komut.Parameters.AddWithValue("@v5", mskTc.Text);
            komut.Parameters.AddWithValue("@v6", mskTel.Text);
            komut.Parameters.AddWithValue("@v7", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@v8", txtDogum.Text);
            komut.Parameters.AddWithValue("@v9", richBxAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            ListeleData();
            MessageBox.Show("Yeni Hemşire Eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblHemsireID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbHastane.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbKlinik.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtDogum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            richBxAdres.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDogum.Clear();
            txtSoyad.Clear();
            txtAd.Clear();
            mskTel.Clear();
            mskTc.Clear();
            cmbCinsiyet.Text = "";
            richBxAdres.Clear();
            cmbKlinik.Text = "";
            cmbHastane.Text = "";
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand HastaneIdCek = new SqlCommand("select HastaneID from Tbl_Hastane where HastaneAdi=@ad", baglanti.SQLBaglanti());
            HastaneIdCek.Parameters.AddWithValue("@ad", cmbHastane.SelectedItem);
            SqlDataReader okuHastaneId = HastaneIdCek.ExecuteReader();
            while (okuHastaneId.Read())
            {
                lblHastaneId.Text = okuHastaneId[0].ToString();
            }

            cmbKlinik.Items.Clear();
            SqlCommand KlinikCek = new SqlCommand("select KlinikID, KlinikAdi from Tbl_Poliklinikler where HastaneId=@hastnId", baglanti.SQLBaglanti());
            KlinikCek.Parameters.AddWithValue("@hastnId", lblHastaneId.Text);
            SqlDataReader KlinikOku = KlinikCek.ExecuteReader();
            while (KlinikOku.Read())
            {
                lblKlinikId.Text = KlinikOku[0].ToString();
                cmbKlinik.Items.Add(KlinikOku[1]).ToString();
            }
        }

        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select KlinikID from Tbl_Poliklinikler where KlinikAdi=@b2", baglanti.SQLBaglanti());
            komut2.Parameters.AddWithValue("@b2", cmbKlinik.Text);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblKlinikId.Text = oku2[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hemsireler set HasteneId=@v1,KlinikId=@v2,Adi=@v3,Soyadi=@v4,TcNo=@v5,Telefon=@v6,Cinsiyet=@v7,DogumTarihi=@v8,Adres=@v9 where HemsireID=@v0", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@v0", lblHemsireID.Text);
            komut.Parameters.AddWithValue("@v1", lblHastaneId.Text);
            komut.Parameters.AddWithValue("@v2", lblKlinikId.Text);
            komut.Parameters.AddWithValue("@v3", txtAd.Text);
            komut.Parameters.AddWithValue("@v4", txtSoyad.Text);
            komut.Parameters.AddWithValue("@v5", mskTc.Text);
            komut.Parameters.AddWithValue("@v6", mskTel.Text);
            komut.Parameters.AddWithValue("@v7", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@v8", txtDogum.Text);
            komut.Parameters.AddWithValue("@v9", richBxAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Güncelleme Başarılı");
            ListeleData();
        }
    }
}
