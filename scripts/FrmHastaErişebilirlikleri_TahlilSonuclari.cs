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
    public partial class FrmHastaErişebilirlikleri_TahlilSonuclari : Form
    {

        SQLConnection baglanti = new SQLConnection();
        public FrmHastaErişebilirlikleri_TahlilSonuclari()
        {
            InitializeComponent();
        }

        private void ListeleData()
        {
            SqlCommand Listele = new SqlCommand("select t.TahlilID,h.HastaneAdi,p.KlinikAdi,d.Unvan+' '+d.Adi+' '+d.Soyadi as [Doktor Ad Soyad],m.MuayeneNedeni,hasta.TcNo, t.TahlilAdi,t.TahlilDurumu,t.TahlilDegeri,t.TahlilTarihi from Tbl_Tahliller as t " +
                "join Tbl_Hastane as h on t.HastaneId=h.HastaneID " +
                "join Tbl_Poliklinikler as p on t.KlinikId=p.KlinikID " +
                "join Tbl_Doktorlar as d on d.DoktorID=t.DoktorId " +
                "join Tbl_MuayeneGecmisi as m on m.MuayeneID=t.MuayeneId " +
                "join Tbl_Hastalar as hasta on hasta.HastaID=t.HastaId where hasta.HastaID=@id", baglanti.SQLBaglanti());
            Listele.Parameters.AddWithValue("@id", lblHastaId.Text);
            SqlDataAdapter da = new SqlDataAdapter(Listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.SQLBaglanti().Close();
        }

        private void pcBxUstDizin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaGirisi HastaMenusu = new FrmHastaGirisi();
            HastaMenusu.idTutan = Convert.ToInt32(lblHastaId.Text);
            HastaMenusu.ShowDialog();
            this.Close();
        }

        private void pcBxAnaEkran_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisEkrani GirisEkrani = new FrmGirisEkrani();
            GirisEkrani.ShowDialog();
            this.Close();
        }

        private void FrmHastaErişebilirlikleri_TahlilSonuclari_Load(object sender, EventArgs e)
        {
            SqlCommand HastaAdiYaz = new SqlCommand("select 'Hoşgeldin '+Adi+' '+Soyadi from Tbl_Hastalar where HastaID=@id", baglanti.SQLBaglanti());
            HastaAdiYaz.Parameters.AddWithValue("@id", lblHastaId.Text);
            SqlDataReader okuad = HastaAdiYaz.ExecuteReader();
            while(okuad.Read())
            {
                label6.Text = okuad[0].ToString();
            }

            ListeleData();   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblTahlilId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTcNo.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtTahlilAdi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtTahlilDurumu.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtTahlilDeger.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtTahlilTarihi.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Tahliller where TahlilID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblTahlilId.Text);
            komut.ExecuteNonQuery();
            baglanti.SQLBaglanti().Close();
            MessageBox.Show("Başarıyla Silindi");
            ListeleData();
        }
    }
}
