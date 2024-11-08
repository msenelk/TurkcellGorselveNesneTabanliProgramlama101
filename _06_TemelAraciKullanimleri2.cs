using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

            #region Chart Aracı
            // Verilerin grafikler üzerinde gösteriminde kullanılan araçtır.
            // Özellikle veritabanı işlemlerinde çokça kullanılır.
            // Gösterimi yapılacak veriler <series> başlığı altında tutulur.
            // Veriler genellikle x ve y koordinatlarında değer ataması yapılır.

            #region Chart Areas(Grafik Alanları)          
            //Name: Her ChartArea'nın benzersiz bir adı olmalıdır.
            //AxisX, AxisY: X ve Y eksenlerinin özelliklerini belirlemenizi sağlar.Bu özellikler eksen başlıkları, aralıklar, çizgi renkleri gibi detayları içerir.
            //BackColor: Grafik alanının arka plan rengini ayarlar.
            //BorderColor: Grafik alanının kenarlık rengini belirler 
            #endregion // Chart Areas(Grafik Alanları)

            #region Series(Seriler)        
            //Name: Her Series'in benzersiz bir adı vardır.
            //ChartType: Grafik türünü belirler(örneğin, SeriesChartType.Line, SeriesChartType.Bar, SeriesChartType.Pie).
            //Points: Grafik üzerindeki veri noktalarını içerir.
            //Color: Serinin rengi.
            //BorderWidth: Serinin çizgi kalınlığı.
            //IsValueShownAsLabel: Verinin etiket olarak gösterilip gösterilmeyeceğini belirler.
            //XValueMember, YValueMembers: Veritabanı ile bağlarken X ve Y eksenindeki veri sütunlarını belirler.
            //MarkerStyle: Veri noktalarının stilini belirler(örneğin, MarkerStyle.Circle, MarkerStyle.Square).
            #endregion // Series(Seriler)

            #region Legends(Açıklamalar)   
            //Name: Her Legend'in benzersiz bir adı vardır.
            //Docking: Legend'ın yerleşim konumunu belirler (örneğin, Docking.Top, Docking.Bottom).
            //BackColor: Arka plan rengini ayarlar.
            //Font: Yazı tipini belirler.
            //Enabled: Legend'ın görünür olup olmadığını belirler.
            #endregion // Legends(Açıklamalar)

            #region Titles(Başlıklar)
            //Text: Başlık metnini ayarlar.
            //Font: Yazı tipi ve boyutunu belirler.
            //Alignment: Başlık hizalamasını ayarlar(örneğin, ContentAlignment.MiddleCenter).
            //ForeColor: Yazı rengini ayarlar.
            #endregion // Titles(Başlıklar)

            #region Chart Properties(Genel Özellikler)       
            //BackColor: Chart kontrolünün arka plan rengini belirler.
            //BorderlineColor: Grafik kenarlık rengini ayarlar.
            //BorderlineWidth: Kenarlık kalınlığını belirler.
            //AntiAliasing: Grafiğin düzgün ve kaliteli görünmesi için anti - aliasing özelliğini etkinleştirir.
            //Palette: Grafik renk paletini belirler(ChartColorPalette.Bright, ChartColorPalette.EarthTones gibi).
            #endregion // Chart Properties(Genel Özellikler)

            #region Axes (Eksenler)
            //Title: Eksenin başlığını ayarlar.
            //Interval: Eksen aralığını belirler.
            //LabelStyle: Eksen üzerindeki etiketlerin stilini tanımlar(yazı tipi, renk, döndürme açısı).
            //MajorGrid: Ana çizgilerin görünürlüğü ve stili.
            //MinorGrid: Ara çizgilerin özellikleri.
            #endregion // Axes (Eksenler)

            #region Chart Events (Olaylar)
            //Click: Grafik üzerine tıklama olayı.
            //MouseMove: Grafik üzerinde fare hareketi izleme.
            //Customize: Grafik özelleştirildiğinde tetiklenen olay.
            //PostPaint ve PrePaint: Çizim öncesi ve sonrası özel işlemler için kullanılır.
            #endregion // Chart Events (Olaylar)

            #endregion // Chart Aracı

            #region Progressbar Aracı
            // Sayısal değerin bir ilerleme çubuğu üzerinde gösterildiği araçtır.
            // Başlangıçta 0-100 arasında değer alır.
            // Minimuz ve maximum değerleri değiştirilebilir.
            #endregion

            InitializeComponent();
        }

        private void _05_TemelAraciKullanimleri2_Load(object sender, EventArgs e)
        {
            chart1.Series["Bolge"].Points.AddXY("Akdeniz",15);
            chart1.Series["Bolge"].Points.AddXY("Ege", 23);
            chart1.Series["Bolge"].Points.AddXY("Karadeniz", 20);
            chart1.Series["Bolge"].Points.AddXY("Doğu Anadolu", 16);
            chart1.Series["Bolge"].Points.AddXY("Marmara", 11);
            // chart.series[eklenecekBolge].Points.AddXY(x-satır verisi, y-sutün verisi)
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

        private void btnArttir_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10; // value değer 
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

        private void btnBaslatPrgBarIslem_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            prgBarIslem1.Value += 10;
            txtIslem1Deger.Text = prgBarIslem1.Value.ToString();
            if (prgBarIslem1.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            prgBarIslem2.Value += 10;
            txtIslem2Deger.Text = prgBarIslem2.Value.ToString(); // Ödev kapsamında bar değerleri yazdırıldı.
            if(prgBarIslem2.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            prgBarIslem3.Value += 10;
            txtIslem3Deger.Text=prgBarIslem3.Value.ToString();
            if(prgBarIslem3 .Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Tüm işlemler tamamlandı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
