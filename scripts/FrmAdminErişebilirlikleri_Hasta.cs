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
    public partial class FrmAdminErişebilirlikleri_Hasta : Form
    {

        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_Hasta()
        {
            InitializeComponent();
        }

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select HastaID, has.HastaneAdi, p.KlinikAdi,d.Unvan+' '+d.Adi+' '+d.Soyadi [Doktor], h.Adi Ad,h.Soyadi Soyad,h.TcNo,h.DogumTarihi,h.KanGrubu,h.Cinsiyet,h.Telefon,h.Mail,h.BabaAdi,h.AnneAdi,h.Adres from Tbl_Hastalar as h " +
            "join Tbl_Hastane as has on h.HastaneId=has.HastaneId " +
            "join Tbl_Poliklinikler as p on h.KlinikId=p.KlinikID " +
            "join Tbl_Doktorlar as d on h.DoktorId=d.DoktorID", baglanti.SQLBaglanti());
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
            UstDizin.AdminId = Convert.ToInt32(lblAdminID.Text);
            UstDizin.ShowDialog();
            this.Close();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            this.Hide();
            FrmAdminErişebilirlikleri_HastaEkleGuncelle HastaEkleGuncelle = new FrmAdminErişebilirlikleri_HastaEkleGuncelle();
            HastaEkleGuncelle.lblAdminId.Text = lblAdminID.Text;
            HastaEkleGuncelle.ShowDialog();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand Listele = new SqlCommand("exec HastalarıListele", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void FrmAdminErişebilirlikleri_Hasta_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminID.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAdminAd.Text = oku[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand Listele = new SqlCommand("select HastaID, has.HastaneAdi, p.KlinikAdi,d.Unvan+' '+d.Adi+' '+d.Soyadi [Doktor], h.Adi Ad,h.Soyadi Soyad,h.TcNo,h.DogumTarihi,h.KanGrubu,h.Cinsiyet,h.Telefon,h.Mail,h.BabaAdi,h.AnneAdi,h.Adres from Tbl_Hastalar as h " +
                "join Tbl_Hastane as has on h.HastaneId=has.HastaneId " +
                "join Tbl_Poliklinikler as p on h.KlinikId=p.KlinikID " +
                "join Tbl_Doktorlar as d on h.DoktorId=d.DoktorID where h.HastaID=@id", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@id", txtAranacakHasta.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
            txtAranacakHasta.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand sil = new SqlCommand("delete from Tbl_Hastalar where HastaID=@a", baglanti.SQLBaglanti());
            sil.Parameters.AddWithValue("@a", txtSilinecekHasta.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silme Başarılı");
            ListeleData();
            txtSilinecekHasta.Text = " ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblHastaId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            SqlCommand komut = new SqlCommand("select * from Tbl_HastaSayisi", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }
    }
}
