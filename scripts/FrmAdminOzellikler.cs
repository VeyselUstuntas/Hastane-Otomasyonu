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
    public partial class FrmAdminOzellikler : Form
    {
        public FrmAdminOzellikler()
        {
            InitializeComponent();
        }

        SQLConnection baglanti = new SQLConnection();
        public object AdminId;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Doktor DoktorEkrani = new FrmAdminErişebilirlikleri_Doktor();
            DoktorEkrani.lblAdminId.Text = AdminId.ToString();
            DoktorEkrani.ShowDialog();
            this.Close();
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Hasta HastaEkrani = new FrmAdminErişebilirlikleri_Hasta();
            HastaEkrani.lblAdminID.Text = lblAdminId.Text;
            HastaEkrani.ShowDialog();
            this.Close();
        }

        private void btnHemsire_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Hemsire HemsireEkrani = new FrmAdminErişebilirlikleri_Hemsire();
            HemsireEkrani.lblAdminId.Text = lblAdminId.Text;
            HemsireEkrani.ShowDialog();
            this.Close();
        }

        private void btnPoliklinik_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Klinik KlinikEkrani = new FrmAdminErişebilirlikleri_Klinik();
            KlinikEkrani.lblAdminId.Text = AdminId.ToString();
            KlinikEkrani.ShowDialog();
            this.Close();
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Randevu RandevuEkrani = new FrmAdminErişebilirlikleri_Randevu();
            RandevuEkrani.lblAdminId.Text = lblAdminId.Text;
            RandevuEkrani.ShowDialog();
            this.Close();
        }

        private void FrmAdminOzellikler_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+ convert(varchar,AdminKullaniciAdi), AdminID from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", AdminId);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                lblAdminAD.Text = oku[0].ToString();
                lblAdminId.Text = oku[1].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnHstnGoreDokS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari DoktorSayisi = new FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari();
            DoktorSayisi.lblAdminId.Text = lblAdminId.Text;
            DoktorSayisi.ShowDialog();
            this.Close();
        }

        private void btnSilinmeRandvu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_SilinenRandevular SilinmisRandevular = new FrmAdminErişebilirlikleri_SilinenRandevular();
            SilinmisRandevular.lblAdminId.Text = lblAdminId.Text;
            SilinmisRandevular.ShowDialog();
            this.Close();
        }
    }
}
