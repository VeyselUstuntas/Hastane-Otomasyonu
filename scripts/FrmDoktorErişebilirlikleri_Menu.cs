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
    public partial class FrmDoktorErişebilirlikleri_Menu : Form
    {
        SQLConnection Baglan = new SQLConnection();
        public int YoneticiId = -1;
        FrmDoktorErişebilirlikleri_DoktorHastaları DoktorHastalari = new FrmDoktorErişebilirlikleri_DoktorHastaları();

        public FrmDoktorErişebilirlikleri_Menu()
        {
            InitializeComponent();
        }

        private void pcBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmDoktorErişebilirlikleri_Menu_Load(object sender, EventArgs e)
        {
            txtYoneticiId.Text = YoneticiId.ToString();
            SqlCommand DoktorIdBul = new SqlCommand("select DoktorId from Tbl_DoktorGiris where YoneticiID=@p0", Baglan.SQLBaglanti());
            DoktorIdBul.Parameters.AddWithValue("@p0", txtYoneticiId.Text);
            SqlDataReader okuId = DoktorIdBul.ExecuteReader();
            while(okuId.Read())
            {
                txtDoktorId.Text = okuId[0].ToString();

            }
            SqlCommand DoktorAdi = new SqlCommand("select 'Hoşgeldiniz '+ Unvan +' '+ Adi +' '+ Soyadi from Tbl_Doktorlar where DoktorID=@p1", Baglan.SQLBaglanti());
            DoktorAdi.Parameters.AddWithValue("@p1", txtDoktorId.Text);
            SqlDataReader oku = DoktorAdi.ExecuteReader();
            while (oku.Read())
            {
                lblAdSoyad.Text = oku[0].ToString();
            }

            Baglan.SQLBaglanti().Close();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoktorErişebilirlikleri_HastaEkle HastaEkle = new FrmDoktorErişebilirlikleri_HastaEkle();
            HastaEkle.txtDoktorID.Text = txtDoktorId.Text;
            HastaEkle.txtYoneticiId.Text = txtYoneticiId.Text;
            HastaEkle.ShowDialog();
            this.Close();

        }

        private void btnHastalarım_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorHastalari.txtDoktorId.Text = txtDoktorId.Text;
            DoktorHastalari.txtYoneticiId.Text = txtYoneticiId.Text;
            DoktorHastalari.ShowDialog();
            this.Close();
        }
    }
}
