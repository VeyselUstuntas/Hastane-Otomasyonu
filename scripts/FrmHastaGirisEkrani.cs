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
    public partial class FrmHastaGirisEkrani : Form
    {
        public FrmHastaGirisEkrani()
        {
            InitializeComponent();
        }
        SQLConnection baglan = new SQLConnection();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
                txtSifre.UseSystemPasswordChar = true;
            else
                txtSifre.UseSystemPasswordChar = false;
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("select * from Tbl_HastaGiris where KullaniciAdi=@d1 and KullaniciSifre=@d2", baglan.SQLBaglanti());
                komut.Parameters.AddWithValue("@d1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@d2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();

                FrmHastaGirisi HastaMenusu = new FrmHastaGirisi();

                if (dr.Read())
                {
                    this.Hide();
                    SqlCommand komut2 = new SqlCommand("select HastaId from Tbl_HastaGiris where KullaniciAdi=@kulAdi and KullaniciSifre=@kSifre", baglan.SQLBaglanti());
                    komut2.Parameters.AddWithValue("@kulAdi", txtKullaniciAdi.Text);
                    komut2.Parameters.AddWithValue("@kSifre", txtSifre.Text);

                    SqlDataReader oku = komut2.ExecuteReader();
                    while (oku.Read())
                    {
                        label4.Text = oku[0].ToString();
                    }
                    HastaMenusu.idTutan = Convert.ToInt32(label4.Text);
                    HastaMenusu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı Adı Veya Şifre");
                    txtKullaniciAdi.Text = " ";
                    txtSifre.Clear();
                    txtKullaniciAdi.Focus();
                }

                baglan.SQLBaglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
                throw;
            }
        }
    }
}
