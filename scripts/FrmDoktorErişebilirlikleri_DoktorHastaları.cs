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
    public partial class FrmDoktorErişebilirlikleri_DoktorHastaları : Form
    {
        SQLConnection baglanti = new SQLConnection();

        private void HastalariListele()
        {
            SqlCommand komut = new SqlCommand("select r.RandevuID ,h.HastaID, h.Adi+' '+h.Soyadi as [Hasta Ad Soyad],h.TcNo,h.DogumTarihi,h.KanGrubu,h.Cinsiyet from Tbl_Randevular r " +
                "join Tbl_Hastalar as h on r.HastaId=h.HastaID where r.DoktorId=@t1", baglanti.SQLBaglanti());

            komut.Parameters.AddWithValue("@t1", txtDoktorId.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public FrmDoktorErişebilirlikleri_DoktorHastaları()
        {
            InitializeComponent();
        }

        private void picBxReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoktorErişebilirlikleri_Menu DoktorBune = new FrmDoktorErişebilirlikleri_Menu();
            DoktorBune.txtDoktorId.Text = txtDoktorId.Text;
            DoktorBune.YoneticiId = Convert.ToInt32(txtYoneticiId.Text);
            DoktorBune.ShowDialog();
            this.Close();
        }

        private void picBxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani DoktorMenu = new FrmGirisEkrani();
            DoktorMenu.ShowDialog();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            HastalariListele();
            dataGridView1.Enabled = true;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand komut = new SqlCommand("select m.MuayeneID,h.HastaID, h.Adi+' '+h.Soyadi, h.TcNo,h.KanGrubu,h.DogumTarihi,h.Cinsiyet as Hasta,m.MuayeneTarihi,m.MuayeneNedeni from Tbl_MuayeneGecmisi as m " +
                "join Tbl_Hastalar as h on m.HastaId=h.HastaID where m.DoktorId=@t1 and h.HastaID=@t2", baglanti.SQLBaglanti());

            komut.Parameters.AddWithValue("@t1", txtDoktorId.Text);
            komut.Parameters.AddWithValue("@t2", txtArancak.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
            txtArancak.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand sil = new SqlCommand("delete from Tbl_Hastalar where HastaID=@id", baglanti.SQLBaglanti());
            sil.Parameters.AddWithValue("@id", txtSilinecek.Text);
            sil.ExecuteNonQuery();

            SqlCommand silKullanici = new SqlCommand("delete from Tbl_HastaGiris where HastaId=@id2", baglanti.SQLBaglanti());
            silKullanici.Parameters.AddWithValue("@id2", txtSilinecek.Text);
            silKullanici.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            txtSilinecek.Text = " ";
            MessageBox.Show("Hasta Kaydı Sistemden Silindi");
            HastalariListele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTahlil.Enabled = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtHastaId.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
            SqlCommand MuayeneId = new SqlCommand("select top 1 MuayeneID,KlinikId,HastaneId,HastaId from Tbl_MuayeneGecmisi where DoktorId=@o1 and HastaId=@o2 order by MuayeneID desc", baglanti.SQLBaglanti());
            MuayeneId.Parameters.AddWithValue("@o1", txtDoktorId.Text);
            MuayeneId.Parameters.AddWithValue("@o2", txtHastaId.Text);
            SqlDataReader okuMuayeneId = MuayeneId.ExecuteReader();
            while (okuMuayeneId.Read())
            {
                txtMuayeneId.Text = okuMuayeneId[0].ToString();
                txtKlinikId.Text = okuMuayeneId[1].ToString();
                txtHastaneId.Text = okuMuayeneId[2].ToString();
                txtHastaId.Text = okuMuayeneId[3].ToString();
            }
        }

        private void btnSika_IlacKadyt_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            SqlCommand komut = new SqlCommand("update Tbl_MuayeneGecmisi set MuayeneNedeni=@f1 where MuayeneID=@f2", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@f1", richTxtSikayet.Text);
            komut.Parameters.AddWithValue("@f2", txtMuayeneId.Text);
            komut.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
        }

        private void FrmDoktorErişebilirlikleri_DoktorHastaları_Load(object sender, EventArgs e)
        {
            btnTahlil.Enabled = false;
            SqlCommand doktoradi = new SqlCommand("select 'Hoşgeldiniz '+Unvan+' '+Adi+' '+Soyadi from Tbl_Doktorlar where DoktorID=@id", baglanti.SQLBaglanti());
            doktoradi.Parameters.AddWithValue("@id", txtDoktorId.Text);
            SqlDataReader okuad = doktoradi.ExecuteReader();
            while(okuad.Read())
            {
                lblDoktorAdSoyad.Text = okuad[0].ToString();
            }

            SqlCommand ilacOku = new SqlCommand("select IlacID,IlacAdi from Tbl_Ilaclar", baglanti.SQLBaglanti());
            SqlDataReader oku = ilacOku.ExecuteReader();
            while(oku.Read())
            {
                cmbBxIlacAd.Items.Add(oku[1].ToString());
            }
            baglanti.SQLBaglanti().Close();
        }

        private void btnIlacYaz_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;

            object secilen = cmbBxIlacAd.SelectedItem;
            int ilacId = -1;

            SqlCommand ilacıdbul = new SqlCommand("select IlacId from Tbl_Ilaclar where IlacAdi=@degisken", baglanti.SQLBaglanti());
            ilacıdbul.Parameters.AddWithValue("@degisken", secilen);
            SqlDataReader okuId = ilacıdbul.ExecuteReader();
            while (okuId.Read())
                ilacId = Convert.ToInt32(okuId[0]);

            SqlCommand ilacYaz = new SqlCommand("update Tbl_MuayeneGecmisi set IlacId=@ilac where MuayeneID=@id", baglanti.SQLBaglanti());
            ilacYaz.Parameters.AddWithValue("@id", txtMuayeneId.Text);
            ilacYaz.Parameters.AddWithValue("@ilac", ilacId);
            ilacYaz.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
        }

        private void btnTahlil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoktorErişebilirlikleri_Tahliller TahlilEkrani = new FrmDoktorErişebilirlikleri_Tahliller();
            TahlilEkrani.lblHastnId.Text = txtHastaneId.Text;
            TahlilEkrani.lblKlinikıd.Text = txtKlinikId.Text;
            TahlilEkrani.lblDoktorId.Text = txtDoktorId.Text;
            TahlilEkrani.lblYoneticiId.Text = txtYoneticiId.Text;
            TahlilEkrani.lblMuayeneId.Text = txtMuayeneId.Text;
            TahlilEkrani.HastaId = txtHastaId.Text;
            TahlilEkrani.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
                dataGridView1.Enabled = false;
            SqlCommand komut = new SqlCommand("exec DoktorHastaSayisiniListele @id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", txtDoktorId.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }
    }
}
