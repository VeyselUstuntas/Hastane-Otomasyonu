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
    public partial class FrmDoktorGirisEkrani : Form
    {
        public int YoneticiId = -1;
        SQLConnection baglanti = new SQLConnection();
        public FrmDoktorGirisEkrani()
        {
            InitializeComponent();
        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Giris = new SqlCommand("select YoneticiID, KullaniciAdi,Sifre from Tbl_DoktorGiris where KullaniciAdi=@d1 and Sifre=@d2", baglanti.SQLBaglanti());
                Giris.Parameters.AddWithValue("@d1", txtKullaniciAdi.Text);
                Giris.Parameters.AddWithValue("@d2", txtSifre.Text);
                SqlDataReader oku = Giris.ExecuteReader();

                if (oku.Read())
                {
                    this.Hide();
                    FrmDoktorErişebilirlikleri_Menu DoktorMenusu = new FrmDoktorErişebilirlikleri_Menu();
                    YoneticiId = (int)oku[0];
                    DoktorMenusu.YoneticiId = YoneticiId;
                    DoktorMenusu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                    txtKullaniciAdi.Focus();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Giris Hatası!!");
                throw;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }
    }
}
