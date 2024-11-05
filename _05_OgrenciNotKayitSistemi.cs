using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtDurum.Text != "" && txtOrtalama.Text != "")
            {
                string adSoyad, ders, numara;
                adSoyad = txtAdSoyad.Text;
                ders = comboBox1.Text;
                numara = ogrenciNo.Text;
                listBox1.Items.Add($"Öğrencinin Adı ve Soyadı: {adSoyad} Seçtiği Ders: {ders} Okul Numarası: {numara} ve ortalaması: {txtOrtalama.Text} ve ders durumu: {txtDurum.Text}");
                sayac++;
                lblSayac.Text = $"Kaydedilen Öğrenci Sayısı: {sayac}";
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durum hesabını yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("----------------------------------------");
        }

        int sayac = 0; // Sayacı dışarıda tanımladık çünkü her butona bastığımızda sayacı yeniden tanımlayıp değer ataması yapıyorduç
        private void btnSayac_Click(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text= sayac.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtDurum.Clear();
            txtOrtalama.Text = "";
            txtSinav1.Text = "";
            txtSinav2.Text = "";
            txtSinav3.Text = "";
            ogrenciNo.Text = "";
            comboBox1.SelectedIndex = -1; //Index üzerine elamanları olduğu için temizlemek istediğimiz zaman -1 indexi yazıyoruz.

            txtAdSoyad.Focus(); // İmleci AdSoyad'a focusla, onun üzerinden başlat.
        }

        private void btnMesajKutusu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya! Derslerimiz devam ediyor.", "Mesaj",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // İlk parametrede mesajın içeriğini yazdık.
            // İkinci parametrede mesajın başlığı.
            // Üçüncü parametrede ise mesaj kutucuğunun evet/hayır butonu alacağını belirttik.
            // Dördüncü parametrede ise mesa kutcuğunun ikonunu belirttik.
        }

        private void btnForDongusu_Click(object sender, EventArgs e)
        {
            for(int i = 0;i <10;i++)
            {
                listBox2.Items.Add($"- Merhaba {i}");
            }
        }

        private void btnForDongusu2_Click(object sender, EventArgs e)
        {
            for(int i =1;i <= 20; i++)
            {
                if(i % 3 == 0)
                    listBox2.Items.Add(i);
            }
        }

        private void btnListBoxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
