using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkcellGorselveNesneTabanliProgramlama201
{
    public partial class _06_TemelAraciKullanimleri2 : Form
    {
        public _06_TemelAraciKullanimleri2()
        {
            #region Menustrip Aracı
            // Masaüstü programlarda yer alan üst menülerin oluşturulması için kullanılan araçlardır.
            // Menüler alt tarafa ve sağ tarafa doğru uzayabilir.
            #endregion // Menustrip Aracı

            #region Web Browser Aracı
            // Form üzerinden web sayfalarına bir yarayıcı ile ulaşmak için kullanılır.
            // Varsayalına olarak internet explorer alt yapısını kullanmaktadır.
            #endregion // Web Browser Aracı

            #region Context Menustrip Aracı
            // Form üzerinde sağ tuş münüsü oluşturmak için kullanılır.
            // Bir formda birden fazla Context Menustrip Aracı oluşturulabilir. Kullanılacak olan sağ tuş menüsü formun özellikleri pencersinden ayarlanır.
            // ContextMenuStrip ile hangi menüyü kullanacağımızı seçiyoruz.
            #endregion // Context Menustrip Aracı

            #region Timer Aracı
            // Zamanlayıcı olarak adlandırılan Timer aracında amaç istenen işlemlerin belirli periyotlarda otomatik olarak gerçekleştirilmesidir.
            // Timer form üzerinde görülen bir araç değildir, arka planda çalışır ve özellikleri çok azdır.
                // Interval: Timer'ın tetiklenme aralığını milisaniye cinsinden belirler. Örneğin, Interval 1000 milisaniye olarak ayarlanırsa, timer her saniyede bir tetiklenir.
                //Enabled: Timer'ın çalışıp çalışmadığını belirleyen bir özelliktir. true ise timer aktif hale gelir ve belirlenen aralıkta Tick olayı tetiklenir.
                //Tick: Timer her tetiklendiğinde oluşan olaydır.Bu olayda timer ile yapılması gereken işlemler tanımlanır.
            #endregion // Timer Aracı

            InitializeComponent();
        }

        private void _05_TemelAraciKullanimleri2_Load(object sender, EventArgs e)
        {

        }

        private void yazdırmaKomutlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Yazdırma Komutları Menü Alanına Tıklandı.";
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Forum ile ilgili bir işlem yapılacaksa This komutu kullanılır.
            this.BackColor = Color.Yellow;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/?hl=tr");
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://x.com/home");
        }

        private void muratYücedağToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://muratyucedag.com");
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulamayı Turkcell Geleceği Yazanlar platformu dersleri altında gerçekleştirmekteyiz.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int sayac=0;
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
            if (sayac == 50) // Burada timer 50 olunca durmasını söyledik.
                timer1.Stop();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timerTrafik.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timerTrafik.Stop();
        }

        int sure = 0;
        private void timerTrafik_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;
            if (sure >= 0 && sure <= 30)
            { 
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }
            if (sure > 30 && sure <= 40) { 
                panel2.BackColor = Color.Yellow;
            }
            if(sure >40 && sure <= 70) { 
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor= Color.Transparent;
            }
            if (sure == 71)
                sure = 0;
        }
    }
}
