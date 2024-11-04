using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TurkcellGorselveNesneTabanliProgramlama201
{
    public partial class _03_LoginForm : Form
    {
        public _03_LoginForm()
        {
            InitializeComponent();
        }

        void kodOlustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 10000);
            textBox4.Text = sayi.ToString();
        }

        private void _03_LoginForm_Load(object sender, EventArgs e)
        {
        // TabIndex özelliği klavyeden tab sıralaması için kullanılır.
        // UseSystemPasswordChar klavyeden veri girişinde şifre girerken görünmemesi için true yapılır
        // MaximizeBox -- ekran büyütme ikonunu kapatıp açar
        // MinimizeBox -- ekran küçültme ikonunu kapatıp açar

        // AutoSizeMode -- GrowAndShrink -- Ekranın büyültme ve küçültme işlevini kaldırır.
        // AutoSizeMode -- GrowOnly -- Ekranın büyültme ve küçültme işlemlerini aktif kılar

        //StartPosition -- formun ekranda ilk açıldığında nerede konumlanacağını belirler
            //Manual: Kendi belirlediğiniz koordinatlara göre açılır.
            //CenterScreen: Ekran ortasında açılır.
            //WindowsDefaultLocation: Windows'un varsayılan konumunda açılır, boyut sabittir.
            //WindowsDefaultBounds: Windows'un varsayılan konum ve boyut ayarlarıyla açılır.
            //CenterParent: Ana formun ortasında açılır

            kodOlustur();
            timer1.Start(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text == "Admin" && txtKullaniciSifre.Text == "123" && textBox3.Text == textBox4.Text)
            {
                _01_DosyaIslemleri From = new _01_DosyaIslemleri();
                From.kullanici = txtKullaniciAdi.Text;
                From.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girişi: Kullanıcı Adı, Şifre veya Kod Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _03_LoginForm_SifremiUnuttum frm = new _03_LoginForm_SifremiUnuttum();
            frm.Show();

        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
              sayac++;
            if(sayac % 2 == 0)
            {
                label3.BackColor = Color.Yellow;
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.BackColor = Color.OrangeRed;
                label3.ForeColor = Color.White;
            }
            if(sayac == 10)
                sayac = 0;
        }
    }
}
