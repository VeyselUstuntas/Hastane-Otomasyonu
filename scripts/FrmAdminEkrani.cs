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
    public partial class FrmAdminEkrani : Form
    {
        public FrmAdminEkrani()
        {
            InitializeComponent();
        }
        SQLConnection baglanti = new SQLConnection();

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }
        private void FrmAdminEkrani_Load(object sender, EventArgs e)
        {
        }
        public object AdminId;
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAdminOzellikler adminOzellikler = new FrmAdminOzellikler();
                SqlCommand giris = new SqlCommand("select AdminID,AdminKullaniciAdi, AdminSifre from Tbl_AdminGiris where AdminKullaniciAdi=@f1 and AdminSifre=@f2 ", baglanti.SQLBaglanti());
                giris.Parameters.AddWithValue("@f1", txtKullaniciAdi.Text);
                giris.Parameters.AddWithValue("@f2", txtSifre.Text);
                SqlDataReader oku = giris.ExecuteReader();
                if(oku.Read())
                {
                    this.Hide();
                    AdminId = oku[0];
                    adminOzellikler.AdminId = AdminId;
                    adminOzellikler.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                }


            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
