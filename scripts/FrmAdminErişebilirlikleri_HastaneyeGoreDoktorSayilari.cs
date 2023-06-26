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
    public partial class FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari()
        {
            InitializeComponent();
        }

        private void FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAdminAd.Text = oku[0].ToString();
            }
            baglanti.SQLBaglanti();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminOzellikler UstDizin = new FrmAdminOzellikler();
            UstDizin.AdminId = lblAdminId.Text;
            UstDizin.ShowDialog();
            this.Close();
        }

        private void rdAnkara_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("exec HastaneyeGoreDoktorSayisi 1", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rdErzurum_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("exec HastaneyeGoreDoktorSayisi 2", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
