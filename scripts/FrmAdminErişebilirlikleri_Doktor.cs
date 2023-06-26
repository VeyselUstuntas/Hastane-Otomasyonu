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
    public partial class FrmAdminErişebilirlikleri_Doktor : Form
    {
        public FrmAdminErişebilirlikleri_Doktor()
        {
            InitializeComponent();
        }

        SQLConnection baglanti = new SQLConnection();

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select DoktorID,hastane.HastaneAdi as [Hastane Adı],klinik.KlinikAdi [Klinik Adı],Unvan+' '+Adi+' '+' ' +Soyadi as [Doktor Bilgisi],Brans, TcNo, Cİnsiyet,DogumTarihi,Adres from Tbl_Doktorlar as doktor " +
             "join Tbl_Hastane as hastane on doktor.HastaneId=hastane.HastaneID join Tbl_Poliklinikler as klinik on doktor.KlinikId=klinik.KlinikID ", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@id", txtAraDoktorId.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void TextBoxlariTemizle()
        {
            txtAraDoktorId.Text = "";
            txtSilDoktorId.Text = "";
        }

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminOzellikler AdminOzellikleri = new FrmAdminOzellikler();
            AdminOzellikleri.AdminId = Convert.ToInt32(lblAdminId.Text);
            AdminOzellikleri.ShowDialog();
            this.Close();

        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_DoktorEkleGuncelle DoktorGuncelleEkle = new FrmAdminErişebilirlikleri_DoktorEkleGuncelle();
            DoktorGuncelleEkle.lblAdmId.Text = lblAdminId.Text;
            DoktorGuncelleEkle.ShowDialog();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand Listele = new SqlCommand("select DoktorID,hastane.HastaneAdi as [Hastane Adı],klinik.KlinikAdi [Klinik Adı],Unvan+' '+Adi+' '+' ' +Soyadi as [Doktor Bilgisi],Brans, TcNo, Cİnsiyet,DogumTarihi,Adres from Tbl_Doktorlar as doktor " +
                "join Tbl_Hastane as hastane on doktor.HastaneId=hastane.HastaneID join Tbl_Poliklinikler as klinik on doktor.KlinikId=klinik.KlinikID", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void FrmAdminErişebilirlikleri_Doktor_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAdminAd.Text = oku[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblDoktorId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand Listele = new SqlCommand("select DoktorID,hastane.HastaneAdi as [Hastane Adı],klinik.KlinikAdi [Klinik Adı],Unvan+' '+Adi+' '+' ' +Soyadi as [Doktor Bilgisi],Brans, TcNo, Cİnsiyet,DogumTarihi,Adres from Tbl_Doktorlar as doktor " +
                "join Tbl_Hastane as hastane on doktor.HastaneId=hastane.HastaneID join Tbl_Poliklinikler as klinik on doktor.KlinikId=klinik.KlinikID where doktor.DoktorID=@id", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@id", txtAraDoktorId.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
            txtAraDoktorId.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from Tbl_Doktorlar where DoktorID=@a", baglanti.SQLBaglanti());
            sil.Parameters.AddWithValue("@a", txtSilDoktorId.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silme Başarılı");
            ListeleData();
            baglanti.SQLBaglanti().Close();
            txtSilDoktorId.Text = " ";
        }
    }
}
