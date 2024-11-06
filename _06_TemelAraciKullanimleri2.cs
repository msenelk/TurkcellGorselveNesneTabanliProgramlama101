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
    }
}
