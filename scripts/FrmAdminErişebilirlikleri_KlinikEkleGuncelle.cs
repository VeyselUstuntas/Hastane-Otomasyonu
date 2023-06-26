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
    public partial class FrmAdminErişebilirlikleri_KlinikEkleGuncelle : Form
    {

        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_KlinikEkleGuncelle()
        {
            InitializeComponent();
        }

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select p.KlinikID,h.HastaneAdi,p.KlinikAdi,p.KlinikAdedi from Tbl_Poliklinikler as p join Tbl_Hastane as h on p.HastaneId=h.HastaneID", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void picBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminErişebilirlikleri_Klinik KlinikEkrani = new FrmAdminErişebilirlikleri_Klinik();
            KlinikEkrani.lblAdminId.Text = lblAdminId.Text;
            KlinikEkrani.ShowDialog();
            this.Close();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani girisEkrani = new FrmGirisEkrani();
            girisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmAdminErişebilirlikleri_KlinikEkleGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAdminAd.Text = oku[0].ToString();
            }

            SqlCommand HastaneCek = new SqlCommand("select HastaneID,HastaneAdi from Tbl_Hastane ", baglanti.SQLBaglanti());
            SqlDataReader okuHastane = HastaneCek.ExecuteReader();
            while (okuHastane.Read())
            {
                cmbHastane.Items.Add(okuHastane[1]).ToString();
            }

            ListeleData();
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select HastaneId From Tbl_Hastane where HastaneAdi=@ad", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@ad", cmbHastane.SelectedItem);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                lblHastaneId.Text = oku[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            cmbHastane.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKlinikAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKlinikAdt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            lblKlinikId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into Tbl_Poliklinikler (HastaneId,KlinikAdi,KlinikAdedi) values(@l1,@l2,@l3)", baglanti.SQLBaglanti());
            ekle.Parameters.AddWithValue("@l1", lblHastaneId.Text);
            ekle.Parameters.AddWithValue("@l2", txtKlinikAd.Text);
            ekle.Parameters.AddWithValue("@l3", txtKlinikAdt.Text);
            ekle.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            ListeleData();
            MessageBox.Show("Yeni Klinik Eklendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand Guncelle = new SqlCommand("update Tbl_Poliklinikler set HastaneId=@m1,KlinikAdi=@m2,KlinikAdedi=@m3 where KlinikID=@m0", baglanti.SQLBaglanti());
            Guncelle.Parameters.AddWithValue("@m0", lblKlinikId.Text);
            Guncelle.Parameters.AddWithValue("@m1", lblHastaneId.Text);
            Guncelle.Parameters.AddWithValue("@m2", txtKlinikAd.Text);
            Guncelle.Parameters.AddWithValue("@m3", txtKlinikAdt.Text);
            Guncelle.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            ListeleData();
            MessageBox.Show("Başarıyla Güncellendi");
        }
    }
}
