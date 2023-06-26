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
    public partial class FrmAdminErişebilirlikleri_Randevu : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmAdminErişebilirlikleri_Randevu()
        {
            InitializeComponent();
        }
        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select RandevuID,H.HastaneAdi,p.KlinikAdi,d.Unvan +' ' + d.Adi+' ' + d.Soyadi as [Doktor],has.HastaID,has.Adi +' ' +has.Soyadi as [Hasta Ad Soyad],r.Tarih ,r.Saat from Tbl_Randevular as r " +
                "join Tbl_Hastane as H on r.HastaneId=H.HastaneID " +
                "join Tbl_Poliklinikler as p on r.KlinikId=p.KlinikID " +
                "join Tbl_Doktorlar as d on r.DoktorId=d.DoktorID " +
                "join Tbl_Hastalar as has on r.HastaId=has.HastaID ", baglanti.SQLBaglanti());
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private object RandevuIdCek()
        {
            object degisken = -1;
            SqlCommand komut = new SqlCommand("select top 1 RandevuID from Tbl_Randevular order by RandevuID desc", baglanti.SQLBaglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
                degisken = oku[0];
            return degisken;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
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

        private void FrmAdminErişebilirlikleri_Randevu_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldiniz '+AdminKullaniciAdi from Tbl_AdminGiris where AdminID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblAdminId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label9.Text = oku[0].ToString();
            }

            SqlCommand HastaneCek = new SqlCommand("select HastaneID,HastaneAdi from Tbl_Hastane", baglanti.SQLBaglanti());
            SqlDataReader okuHastane = HastaneCek.ExecuteReader();
            while (okuHastane.Read())
            {
                cmbHastane.Items.Add(okuHastane[1]).ToString();
            }

            baglanti.SQLBaglanti().Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListeleData();
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("select HastaneID from Tbl_Hastane where HastaneAdi=@b1", baglanti.SQLBaglanti());
            komut3.Parameters.AddWithValue("@b1", cmbHastane.Text);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblHastaneId.Text = oku3[0].ToString();
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
            baglanti.SQLBaglanti().Close();
        }

        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select KlinikID from Tbl_Poliklinikler where KlinikAdi=@b2", baglanti.SQLBaglanti());
            komut2.Parameters.AddWithValue("@b2", cmbKlinik.Text);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblKlinikId.Text = oku2[0].ToString();
            }

            SqlCommand DoktorCek = new SqlCommand("select DoktorID,Unvan+' '+Adi+' '+Soyadi from Tbl_Doktorlar where KlinikId=@klId ", baglanti.SQLBaglanti());
            DoktorCek.Parameters.AddWithValue("@klId", lblKlinikId.Text);
            SqlDataReader DoktorOku = DoktorCek.ExecuteReader();
            while (DoktorOku.Read())
            {
                cmbDoktor.Items.Add(DoktorOku[1]).ToString();
            }
            baglanti.SQLBaglanti().Close();

        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand DoktorIdCek = new SqlCommand("select DoktorID from Tbl_Doktorlar where Unvan+' '+Adi+' '+Soyadi=@adiSoy ", baglanti.SQLBaglanti());
            DoktorIdCek.Parameters.AddWithValue("@adiSoy", cmbDoktor.SelectedItem);
            SqlDataReader okuDoktorId = DoktorIdCek.ExecuteReader();
            while (okuDoktorId.Read())
            {
                lblDokId.Text = okuDoktorId[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into Tbl_Randevular (HastaneId,KlinikId,DoktorId,HastaId,Tarih,Saat) values (@j1,@j2,@j3,@j4,@j5,@j6)", baglanti.SQLBaglanti());
            ekle.Parameters.AddWithValue("@j1", lblHastaneId.Text);
            ekle.Parameters.AddWithValue("@j2", lblKlinikId.Text);
            ekle.Parameters.AddWithValue("@j3", lblDokId.Text);
            ekle.Parameters.AddWithValue("@j4", txtHastaId.Text);
            ekle.Parameters.AddWithValue("@j5", dateTimePicker1.Text);
            ekle.Parameters.AddWithValue("@j6", cmbSaat.Text);
            ekle.ExecuteNonQuery();

            SqlCommand YeniRandevuyuGuncelle = new SqlCommand("update Tbl_Hastalar set HastaneId=@p1,KlinikId=@p2,DoktorId=@p3 where HastaID=@p0 ", baglanti.SQLBaglanti());
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p0", txtHastaId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p1", lblHastaneId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p2", lblKlinikId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p3", lblDokId.Text);
            YeniRandevuyuGuncelle.ExecuteNonQuery();

            SqlCommand ekle2 = new SqlCommand("insert into Tbl_MuayeneGecmisi (HastaneId,KlinikId,DoktorId,HastaId,RandevuId,MuayeneTarihi) values (@j11,@j12,@j13,@j14,@j15,@j16)", baglanti.SQLBaglanti());
            ekle2.Parameters.AddWithValue("@j11", lblHastaneId.Text);
            ekle2.Parameters.AddWithValue("@j12", lblKlinikId.Text);
            ekle2.Parameters.AddWithValue("@j13", lblDokId.Text);
            ekle2.Parameters.AddWithValue("@j14", txtHastaId.Text);
            ekle2.Parameters.AddWithValue("@j15", RandevuIdCek());
            ekle2.Parameters.AddWithValue("@j16", dateTimePicker1.Text);
            ekle2.ExecuteNonQuery();
            ListeleData();
            MessageBox.Show("Randevu Başarıyla Eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblRandevuId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbHastane.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbKlinik.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbDoktor.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            lblHastaId.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbSaat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil1 = new SqlCommand("delete From Tbl_MuayeneGecmisi where HastaId=@hid and DoktorId=@did", baglanti.SQLBaglanti());
            sil1.Parameters.AddWithValue("@hid", lblHastaId.Text);
            sil1.Parameters.AddWithValue("@did", lblDokId.Text);
            sil1.ExecuteNonQuery();

            SqlCommand sil2 = new SqlCommand("delete from Tbl_Randevular where RandevuID=@rid", baglanti.SQLBaglanti());
            sil2.Parameters.AddWithValue("@rid", lblRandevuId.Text);
            sil2.ExecuteNonQuery();
            ListeleData();
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            SqlCommand koumt = new SqlCommand("update Tbl_Randevular set HastaneId=@f1,KlinikId=@f2,DoktorId=@f3,Tarih=@f4,Saat=@f5 where RandevuID=@f0", baglanti.SQLBaglanti());
            koumt.Parameters.AddWithValue("@f0", lblRandevuId.Text);
            koumt.Parameters.AddWithValue("@f1", lblHastaneId.Text);
            koumt.Parameters.AddWithValue("@f2", lblKlinikId.Text);
            koumt.Parameters.AddWithValue("@f3", lblDokId.Text);
            koumt.Parameters.AddWithValue("@f4", dateTimePicker1.Text);
            koumt.Parameters.AddWithValue("@f5", cmbSaat.Text);
            koumt.ExecuteNonQuery();

            SqlCommand YeniRandevuyuGuncelle = new SqlCommand("update Tbl_Hastalar set HastaneId=@p1,KlinikId=@p2,DoktorId=@p3 where HastaID=@p0 ", baglanti.SQLBaglanti());
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p0", lblHastaId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p1", lblHastaneId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p2", lblKlinikId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p3", lblDokId.Text);
            YeniRandevuyuGuncelle.ExecuteNonQuery();


            SqlCommand komut = new SqlCommand("update Tbl_MuayeneGecmisi set HastaneId=@g1,KlinikId=@g2,DoktorId=@g3,MuayeneTarihi=@g4 where RandevuId=@g5", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@g1", lblHastaneId.Text);
            komut.Parameters.AddWithValue("@g2", lblKlinikId.Text);
            komut.Parameters.AddWithValue("@g3", lblDokId.Text);
            komut.Parameters.AddWithValue("@g4", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@g5",lblRandevuId.Text);
            komut.ExecuteNonQuery();

            ListeleData();
            MessageBox.Show("Başarıyla Günellendi");
        }
    }
}
