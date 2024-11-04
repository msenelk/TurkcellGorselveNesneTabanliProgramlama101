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
    public partial class _04_TemelAracKullanimlari : Form
    {
        public _04_TemelAracKullanimlari()
        {
            InitializeComponent();
        }

        private void _04_TemelAracKullanimlari_Load(object sender, EventArgs e)
        {
            #region Tool
            // Tool => Araç demek
            // Toolbox => Araç kutusu
            #endregion

            #region Properties
            // Properties => Text => Label Aracının Görünen Metni
            // Properties => BackColor => Arka plan rengi
            // Properties => ForeColor => Yazı rengi

            #endregion // Properties

            #region Label Aracı
            // Açıklamalar için kullanılan, etiket görevi gören araçtır.
            // Amaç ilgili bileşen hakkında bilgi vermektir.
            // Properties => Text => Label Aracının Görünen Metni
            #endregion // Label Aracı

            #region Button Aracı
            // Olayları gerçekleştirmek için kullanılan tetikleme aracıdır.
            // Properties => BackColor => Arka plan rengi
            // Properties => ForeColor => Yazı rengi
            #endregion // Button Aracı

            #region TexBox Aracı
            // Kullanıcıdan veri girişi yapmak için kullanılır.
            #endregion // TexBox Aracı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buraya butona tıklandığında ne olacağını yazıyoruz.
            label6.Text = "Kocaeli"; // Butona tıklanıldığında label6 nın metnini Kocaeli olarak değiştirecektir.
            label8.Text = textBox1.Text; // Butona tıklanıldığında textBox1 de yer alan metin label8 e atanacaktır.
            // textBox1.Text = "Veri Girişi" TextBox aracına dışarıdan da veri girişi gerçekleştirilebilir.
        }
    }
}
