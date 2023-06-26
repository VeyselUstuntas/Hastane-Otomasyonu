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
    public partial class FrmAdminErişebilirlikleri_SilinenRandevular : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_SilinenRandevular()
        {
            InitializeComponent();
        }

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("exec SilinmisRandevulariListele", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void pcBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminOzellikler AdminOzellikleri = new FrmAdminOzellikler();
            AdminOzellikleri.AdminId = lblAdminId.Text;
            AdminOzellikleri.ShowDialog();
            this.Close();
        }

        private void pcBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmAdminErişebilirlikleri_SilinenRandevular_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                lblAdminAd.Text=oku[0].ToString();
            }

            ListeleData();
        }
    }
}
