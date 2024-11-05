using System;
using System.Windows.Forms;

namespace TurkcellGorselveNesneTabanliProgramlama201
{
    public partial class _05_OgrenciNotKayitSistemi : Form
    {
        public _05_OgrenciNotKayitSistemi()
        {
            InitializeComponent();
        }

        private void _05_OgrenciNotKayitSistemi_Load(object sender, EventArgs e)
        {
            #region Araçların Adlandırılması
            // Adlandırma yapılırken kullanılan aracın ilk üç sessiz harfi kullanılır sonrasında da alacağı işlem yazılır.
            // txtAdSoyad
            #endregion
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;

            s1 = Convert.ToInt16(txtSinav1.Text); // string veriden int veriye dönüşüm yapmak için Covert metodunu kullandık.
            s2=Convert.ToInt16(txtSinav2.Text);
            s3=Convert.ToInt16(txtSinav3.Text);

            ort = (s1 + s2 + s3) / 3;
            txtOrtalama.Text = ort.ToString(); // int veriyi string veriye dönüştürdük.

            if(ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            txtDurum.Text = durum; // Burada bir çevirme işlemi yapmadık çünkü durum değişkeni string :)
        }
    }
}
