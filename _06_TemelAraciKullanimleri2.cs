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


            InitializeComponent();
        }

        private void _05_TemelAraciKullanimleri2_Load(object sender, EventArgs e)
        {

        }

        private void yazdırmaKomutlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Yazdırma Komutları Menü Alanına Tıklandı.";
        }
    }
}
