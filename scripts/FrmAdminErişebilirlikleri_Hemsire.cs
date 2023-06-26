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
    public partial class FrmAdminErişebilirlikleri_Hemsire : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_Hemsire()
        {
            InitializeComponent();
        }
        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("exec HemsireleriListele", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }
        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminOzellikler UstDizin = new FrmAdminOzellikler();
            UstDizin.AdminId = lblAdminId.Text;
            UstDizin.ShowDialog();
            this.Close();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_HemsireEkleGuncelle HemsireEkleGuncelle = new FrmAdminErişebilirlikleri_HemsireEkleGuncelle();
            HemsireEkleGuncelle.lblAdminId.Text = lblAdminId.Text;
            HemsireEkleGuncelle.ShowDialog();
            this.Close();
        }

        private void FrmAdminErişebilirlikleri_Hemsire_Load(object sender, EventArgs e)
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

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeleData();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand Listele = new SqlCommand("select hem.HemsireID,h.HastaneAdi,p.KlinikAdi,hem.Adi+' '+hem.Soyadi [Ad Soyad],hem.TcNo,hem.DogumTarihi,hem.Cinsiyet,hem.Telefon,hem.Adres from Tbl_Hemsireler as hem " +
                "join Tbl_Hastane as h on hem.HasteneId=h.HastaneID " +
                "join Tbl_Poliklinikler as p on p.KlinikID=hem.KlinikId where hem.HemsireID=@Id", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@Id", txtAranacak.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
            txtSilinecek.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from Tbl_Hemsireler where HemsireID=@a", baglanti.SQLBaglanti());
            sil.Parameters.AddWithValue("@a", txtSilinecek.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silme Başarılı");
            ListeleData();
            txtAranacak.Text = " ";
        }
    }
    
}
