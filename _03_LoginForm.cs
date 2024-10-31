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

        }
    }
}
