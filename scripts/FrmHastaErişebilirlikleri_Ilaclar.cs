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
    public partial class FrmHastaErişebilirlikleri_Ilaclar : Form
    {
        SQLConnection baglanti = new SQLConnection();
        public FrmHastaErişebilirlikleri_Ilaclar()
        {
            InitializeComponent();
        }

        private void ListeleData()
        {

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

        private void FrmHastaErişebilirlikleri_Ilaclar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select 'Hoşgeldin '+Adi+' '+Soyadi from Tbl_Hastalar where HastaID=@id", baglanti.SQLBaglanti());
            komut.Parameters.AddWithValue("@id", lblHastaId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label6.Text = oku[0].ToString();
            }
        }
    }
}
