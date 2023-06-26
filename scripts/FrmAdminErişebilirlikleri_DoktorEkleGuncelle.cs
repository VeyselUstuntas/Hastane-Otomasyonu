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
    public partial class FrmAdminErişebilirlikleri_DoktorEkleGuncelle : Form
    {

        SQLConnection baglanti = new SQLConnection();
        HastaIdCek IdAl = new HastaIdCek();
        public FrmAdminErişebilirlikleri_DoktorEkleGuncelle()
        {
            InitializeComponent();
        }

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Doktor DoktorBilgiEkrani = new FrmAdminErişebilirlikleri_Doktor();
            DoktorBilgiEkrani.lblAdminId.Text = lblAdmId.Text;
            DoktorBilgiEkrani.ShowDialog();
            this.Close();
        }

        private void Listele()
        {
            SqlCommand Listele = new SqlCommand("select DoktorID,hastane.HastaneAdi as [Hastane Adı],klinik.KlinikAdi [Klinik Adı],doktor.Unvan as Unvan, doktor.Adi Adı,doktor.Soyadi as [Soyadı],Brans, TcNo, Telefon,Cİnsiyet,DogumTarihi,Adres from Tbl_Doktorlar as doktor " +
             "join Tbl_Hastane as hastane on doktor.HastaneId=hastane.HastaneID join Tbl_Poliklinikler as klinik on doktor.KlinikId=klinik.KlinikID", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void TextBoxlariTemzle()
        {
            txtAd.Clear();
            txtAnadal.Clear();
            txtSoyad.Clear();
            txtUnvan.Clear();
            txtDogumT.Clear();
            mskTc.Clear();
            mskTel.Clear();
            richBxAdres.Clear();
            cmbHastane.Items.Clear();
            cmbCinsiyet.Text = "";
            cmbHastane.Text = "";
            cmbKlinik.Text = "";
            txtKulAdi.Clear();
            mskSifre.Clear();
        }

        private void picBxGirisEkrani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmAdminErişebilirlikleri_DoktorEkleGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdmId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label11.Text = oku[0].ToString();
            }
            baglanti.SQLBaglanti().Close();

            cmbHastane.Items.Clear();
            cmbHastane.Text = "";

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

            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblDokId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbHastane.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbKlinik.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtUnvan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtAnadal.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtDogumT.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            richBxAdres.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();

            SqlCommand DoktorKad = new SqlCommand("select KullaniciAdi, Sifre from Tbl_DoktorGiris where DoktorId=@dId", baglanti.SQLBaglanti());
            DoktorKad.Parameters.AddWithValue("@dId", lblDokId.Text);
            SqlDataReader okukullad = DoktorKad.ExecuteReader();
            while(okukullad.Read())
            {
                txtKulAdi.Text = okukullad[0].ToString();
                mskSifre.Text = okukullad[1].ToString();
            }

            SqlCommand komut = new SqlCommand("select HastaneID from Tbl_Hastane where HastaneAdi=@b1", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@b1", cmbHastane.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                lblHastaneId.Text = oku[0].ToString();
            }

            SqlCommand komut2 = new SqlCommand("select KlinikID from Tbl_Poliklinikler where KlinikAdi=@b2", baglanti.SQLBaglanti());
            komut2.Parameters.AddWithValue("@b2", cmbKlinik.Text);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblKlinikId.Text = oku2[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand Ekle = new SqlCommand("insert into Tbl_Doktorlar (HastaneId,KlinikId,Unvan,Adi,Soyadi,Brans,TcNo,Telefon,Cinsiyet,DogumTarihi,Adres)" +
                " values(@o1,@o2,@o3,@o4,@o5,@o6,@o7,@o8,@o9,@o10,@o11)",baglanti.SQLBaglanti());
            Ekle.Parameters.AddWithValue("@o1", lblHastaneId.Text);
            Ekle.Parameters.AddWithValue("@o2", lblKlinikId.Text);
            Ekle.Parameters.AddWithValue("@o3", txtUnvan.Text);
            Ekle.Parameters.AddWithValue("@o4", txtAd.Text);
            Ekle.Parameters.AddWithValue("@o5", txtSoyad.Text);
            Ekle.Parameters.AddWithValue("@o6", txtAnadal.Text);
            Ekle.Parameters.AddWithValue("@o7", mskTc.Text);
            Ekle.Parameters.AddWithValue("@o8", mskTel.Text);
            Ekle.Parameters.AddWithValue("@o9", cmbCinsiyet.Text);
            Ekle.Parameters.AddWithValue("@o10", txtDogumT.Text);
            Ekle.Parameters.AddWithValue("@o11", richBxAdres.Text);
            Ekle.ExecuteNonQuery();

            SqlCommand Ekle2 = new SqlCommand("insert into Tbl_DoktorGiris (HastaneId,KlinikId,DoktorId,KullaniciAdi,Sifre) values(@p1,@p2,@p3,@p4,@p5)", baglanti.SQLBaglanti());
            Ekle2.Parameters.AddWithValue("@p1", lblHastaneId.Text);
            Ekle2.Parameters.AddWithValue("@p2", lblKlinikId.Text);
            Ekle2.Parameters.AddWithValue("@p3", IdAl.DoktorIdCek());
            Ekle2.Parameters.AddWithValue("@p4", txtKulAdi.Text);
            Ekle2.Parameters.AddWithValue("@p5", mskSifre.Text);
            Ekle2.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Yeni Doktor Kaydı Başarıyla Eklendi");
            Listele();

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
            //lblHastnId.Text = cmbKlinik.SelectedIndex.ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TextBoxlariTemzle();
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
            SqlCommand guncelle = new SqlCommand("update Tbl_Doktorlar set [HastaneId]=@o1,[KlinikId]=@o2,[Unvan]=@o3,[Adi]=@o4,[Soyadi]=@o5,[Brans]=@o6,[TcNo]=@o7,[Telefon]=@o8,[Cinsiyet]=@o9,[DogumTarihi]=@o10,[Adres]=@o11 where DoktorID=@o0",baglanti.SQLBaglanti());
            guncelle.Parameters.AddWithValue("@o0", lblDokId.Text);
            guncelle.Parameters.AddWithValue("@o1", lblHastaneId.Text);
            guncelle.Parameters.AddWithValue("@o2", lblKlinikId.Text);
            guncelle.Parameters.AddWithValue("@o3", txtUnvan.Text);
            guncelle.Parameters.AddWithValue("@o4", txtAd.Text);
            guncelle.Parameters.AddWithValue("@o5", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@o6", txtAnadal.Text);
            guncelle.Parameters.AddWithValue("@o7", mskTc.Text);
            guncelle.Parameters.AddWithValue("@o8", mskTel.Text);
            guncelle.Parameters.AddWithValue("@o9", cmbCinsiyet.Text);
            guncelle.Parameters.AddWithValue("@o10", txtDogumT.Text);
            guncelle.Parameters.AddWithValue("@o11", richBxAdres.Text);
            guncelle.ExecuteNonQuery();

            SqlCommand guncelle2 = new SqlCommand("update Tbl_DoktorGiris set KullaniciAdi=@y1,Sifre=@y2 where DoktorId=@y0", baglanti.SQLBaglanti());
            guncelle2.Parameters.AddWithValue("@y0", lblDokId.Text);
            guncelle2.Parameters.AddWithValue("@y1", txtKulAdi.Text);
            guncelle2.Parameters.AddWithValue("@y2", mskSifre.Text);
            guncelle2.ExecuteNonQuery();

            baglanti.SQLBaglanti();
            MessageBox.Show("Başarıyla Güncellendi");
            Listele();

        }
    }
}
