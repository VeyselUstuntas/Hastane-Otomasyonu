using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }
        private void AdminGirişEkrani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminEkrani AdminEkrani = new FrmAdminEkrani();
            AdminEkrani.ShowDialog();
            this.Close();

        }
        private void HastaGirisEkrani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaKayit_ve_Giris HastaGirisEkrani = new FrmHastaKayit_ve_Giris();
            HastaGirisEkrani.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoktorGirisEkrani DoktorGirisiEkrani = new FrmDoktorGirisEkrani();
            DoktorGirisiEkrani.ShowDialog();
            this.Close();
        }
    }
}
