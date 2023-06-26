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
    public partial class FrmAdminErişebilirlikleri_Klinik : Form
    {
        public FrmAdminErişebilirlikleri_Klinik()
        {
            InitializeComponent();
        }

        SQLConnection baglanti = new SQLConnection();

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select p.KlinikID,h.HastaneSehir, h.HastaneAdi,p.KlinikAdi,p.KlinikAdedi from Tbl_Poliklinikler as p join Tbl_Hastane as h on p.HastaneId=h.HastaneID", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void FrmAdminErişebilirlikleri_Klinik_Load(object sender, EventArgs e)
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

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminOzellikler AdminEkrani = new FrmAdminOzellikler();
            AdminEkrani.AdminId = lblAdminId.Text;
            AdminEkrani.ShowDialog();
            this.Close();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeleData();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand Listele = new SqlCommand("select p.KlinikID,h.HastaneSehir, h.HastaneAdi,p.KlinikAdi,p.KlinikAdedi from Tbl_Poliklinikler as p join Tbl_Hastane as h on p.HastaneId=h.HastaneID where p.KlinikID=@id", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@id",txtAranacakKli.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand Listele = new SqlCommand("delete from Tbl_Poliklinikler where KlinikID=@id", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@id", txtSilinecekKlini.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Silme Başarılı");
            ListeleData();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_KlinikEkleGuncelle KlinikEkleGuncelle = new FrmAdminErişebilirlikleri_KlinikEkleGuncelle();
            KlinikEkleGuncelle.lblAdminId.Text = lblAdminId.Text;
            KlinikEkleGuncelle.ShowDialog();
            this.Close();
        }
    }
}
