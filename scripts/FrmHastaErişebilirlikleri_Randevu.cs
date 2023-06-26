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
    public partial class FrmHastaErişebilirlikleri_Randevu : Form
    {
        SQLConnection baglanti = new SQLConnection();

        private void ListeleData()
        {
            SqlCommand komut = new SqlCommand("select r.RandevuID,h.HastaneAdi,p.KlinikAdi,d.Unvan+' '+Adi+' '+Soyadi as Doktor_Adı,r.Tarih,r.Saat from Tbl_Randevular as r " +
                "join Tbl_Hastane as h on r.HastaneId=h.HastaneID " +
                "join Tbl_Poliklinikler as p on r.KlinikId=p.KlinikID " +
                "join Tbl_Doktorlar as d on r.DoktorId=d.DoktorID where HastaId =@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public FrmHastaErişebilirlikleri_Randevu()
        {
            InitializeComponent();
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
            FrmHastaGirisi UstDizin = new FrmHastaGirisi();
            UstDizin.idTutan = Convert.ToInt32(textBox1.Text);
            UstDizin.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmHastaErişebilirlikleri_Randevu_Load(object sender, EventArgs e)
        {
            SqlCommand HastaneCek = new SqlCommand("select HastaneID,HastaneAdi from Tbl_Hastane", baglanti.SQLBaglanti());
            SqlDataReader okuHastane = HastaneCek.ExecuteReader();
            while (okuHastane.Read())
            {
                cmbHastane.Items.Add(okuHastane[1]).ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand HastaneIdCek = new SqlCommand("select HastaneID from Tbl_Hastane where HastaneAdi=@ad", baglanti.SQLBaglanti());
            HastaneIdCek.Parameters.AddWithValue("@ad", cmbHastane.SelectedItem);
            SqlDataReader okuHastaneId = HastaneIdCek.ExecuteReader();
            while (okuHastaneId.Read())
            {
                txtHastaneId.Text = okuHastaneId[0].ToString();
            }
            
            cmbKlinik.Items.Clear();
            SqlCommand KlinikCek = new SqlCommand("select KlinikID, KlinikAdi from Tbl_Poliklinikler where HastaneId=@hastnId", baglanti.SQLBaglanti());
            KlinikCek.Parameters.AddWithValue("@hastnId", txtHastaneId.Text);
            SqlDataReader KlinikOku = KlinikCek.ExecuteReader();
            while (KlinikOku.Read())
            {
                txtKlinikId.Text = KlinikOku[0].ToString();
                cmbKlinik.Items.Add(KlinikOku[1]).ToString();
            }
            //lblHastnId.Text = cmbKlinik.SelectedIndex.ToString();

            baglanti.SQLBaglanti().Close();
        }

        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            int klinikId = -1;
            SqlCommand klinikIdBul = new SqlCommand("select KlinikID from Tbl_Poliklinikler where KlinikAdi=@ad", baglanti.SQLBaglanti());
            klinikIdBul.Parameters.AddWithValue("@ad", cmbKlinik.SelectedItem);
            SqlDataReader dr = klinikIdBul.ExecuteReader();
            while (dr.Read())
            {
                klinikId = (int)dr[0];
            }
            txtKlinikId.Text = klinikId.ToString();

            cmbDoktor.Items.Clear();
            SqlCommand DoktorCek = new SqlCommand("select DoktorID,Unvan+' '+Adi+' '+Soyadi from Tbl_Doktorlar where KlinikId=@klId ", baglanti.SQLBaglanti());
            //DoktorCek.Parameters.AddWithValue("@hstnId", cmbHastane.SelectedIndex + 1);
            DoktorCek.Parameters.AddWithValue("@klId", txtKlinikId.Text);
            SqlDataReader DoktorOku = DoktorCek.ExecuteReader();
            while (DoktorOku.Read())
            {
                cmbDoktor.Items.Add(DoktorOku[1]).ToString();
            }
            baglanti.SQLBaglanti().Close();
        }
        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand DoktorIdCek = new SqlCommand("select DoktorID from Tbl_Doktorlar where Unvan+' '+Adi+' '+Soyadi=@adiSoy ",baglanti.SQLBaglanti());
            DoktorIdCek.Parameters.AddWithValue("@adiSoy", cmbDoktor.SelectedItem);
            SqlDataReader okuDoktorId = DoktorIdCek.ExecuteReader();
            while(okuDoktorId.Read())
            {
                txtDoktorId.Text = okuDoktorId[0].ToString();
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand RandevuAl = new SqlCommand("insert into Tbl_Randevular (HastaneId,KlinikId,DoktorId,HastaId,Tarih,Saat) " +
                "values (@v1,@v2,@v3,@v4,@v5,@v6)", baglanti.SQLBaglanti());
            RandevuAl.Parameters.AddWithValue("@v1", txtHastaneId.Text);
            RandevuAl.Parameters.AddWithValue("@v2", txtKlinikId.Text);
            RandevuAl.Parameters.AddWithValue("@v3", txtDoktorId.Text);
            RandevuAl.Parameters.AddWithValue("@v4", textBox1.Text);
            RandevuAl.Parameters.AddWithValue("@v5", dateTimePicker1.Text);
            RandevuAl.Parameters.AddWithValue("@v6", cmbSaat.Text);
            RandevuAl.ExecuteNonQuery();

            SqlCommand YeniRandevuyuGuncelle = new SqlCommand("update Tbl_Hastalar set HastaneId=@p1,KlinikId=@p2,DoktorId=@p3 where HastaId=@p0 ", baglanti.SQLBaglanti());
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p0", textBox1.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p1", txtHastaneId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p2", txtKlinikId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p3", txtDoktorId.Text);
            YeniRandevuyuGuncelle.ExecuteNonQuery();

            SqlCommand MuayeneGecmisi = new SqlCommand("insert into Tbl_MuayeneGecmisi (HastaneId,KlinikId,DoktorId,HastaId,RandevuId,MuayeneTarihi)" +
                "values(@g1,@g2,@g3,@g4,@g5,@g6)", baglanti.SQLBaglanti());
            MuayeneGecmisi.Parameters.AddWithValue("@g1", txtHastaneId.Text);
            MuayeneGecmisi.Parameters.AddWithValue("@g2", txtKlinikId.Text);
            MuayeneGecmisi.Parameters.AddWithValue("@g3", txtDoktorId.Text);
            MuayeneGecmisi.Parameters.AddWithValue("@g4", textBox1.Text);
            MuayeneGecmisi.Parameters.AddWithValue("@g5", RandevuIdCek());
            MuayeneGecmisi.Parameters.AddWithValue("@g6", dateTimePicker1.Text);

            MuayeneGecmisi.ExecuteNonQuery();
            ListeleData();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Randevu Alındı");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListeleData();
            baglanti.SQLBaglanti().Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblSilinecekId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbHastane.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbKlinik.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbDoktor.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbSaat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            baglanti.SQLBaglanti().Close();
            //txtHastaneId.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            //txtKlinikId.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            //txtDoktorId.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            //textBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand randevuSil = new SqlCommand("delete from Tbl_Randevular where RandevuID=@id", baglanti.SQLBaglanti());
            randevuSil.Parameters.AddWithValue("@id", lblSilinecekId.Text);
            randevuSil.ExecuteNonQuery();
            ListeleData();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Randevu Silindi");

        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            SqlCommand Guncelle = new SqlCommand("update Tbl_Randevular set HastaneId=@l1, KlinikId=@l2, DoktorId=@l3,Tarih=@l4,Saat=@l5 where RandevuID=@l0 ", baglanti.SQLBaglanti());
            Guncelle.Parameters.AddWithValue("@l0", lblSilinecekId.Text);
            Guncelle.Parameters.AddWithValue("@l1", txtHastaneId.Text);
            Guncelle.Parameters.AddWithValue("@l2", txtKlinikId.Text);
            Guncelle.Parameters.AddWithValue("@l3", txtDoktorId.Text);
            Guncelle.Parameters.AddWithValue("@l4", dateTimePicker1.Text);
            Guncelle.Parameters.AddWithValue("@l5", cmbSaat.Text);
            Guncelle.ExecuteNonQuery();


            SqlCommand YeniRandevuyuGuncelle = new SqlCommand("update Tbl_Hastalar set HastaneId=@p1,KlinikId=@p2,DoktorId=@p3 where HastaID=@p0 ", baglanti.SQLBaglanti());
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p0", textBox1.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p1", txtHastaneId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p2", txtKlinikId.Text);
            YeniRandevuyuGuncelle.Parameters.AddWithValue("@p3", txtDoktorId.Text);
            YeniRandevuyuGuncelle.ExecuteNonQuery();


            SqlCommand komut = new SqlCommand("update Tbl_MuayeneGecmisi set HastaneId=@g1,KlinikId=@g2,DoktorId=@g3,MuayeneTarihi=@g4 where RandevuId=@g5", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@g1", txtHastaneId.Text);
            komut.Parameters.AddWithValue("@g2", txtKlinikId.Text);
            komut.Parameters.AddWithValue("@g3", txtDoktorId.Text);
            komut.Parameters.AddWithValue("@g4", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@g5", lblSilinecekId.Text);
            komut.ExecuteNonQuery();

            ListeleData();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Başarıyla Günellendi");
        }

    }
}
