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
    public partial class FrmHastaKayit_ve_Giris : Form
    {
        public FrmHastaKayit_ve_Giris()
        {
            InitializeComponent();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaKaydı YeniKayit = new FrmHastaKaydı();
            YeniKayit.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHastaGirisEkrani HastaGirisEkrani = new FrmHastaGirisEkrani();
            HastaGirisEkrani.ShowDialog();
            this.Close();
        }
    }
}
