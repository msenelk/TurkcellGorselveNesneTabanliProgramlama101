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
            // Properties => DropDownStyle => DropDownList => Combobox için dışarıdan veri girişini engeller, sadece seçim yapılabilir.
            //               DropDownStyle => Simple => Listesiz kullanım sunmakta, pek tercih edilebilir değil.
            // Properties => Enabled => Bu özellik hernagi bir araca dışarıdan müdahale edilmesini/veri girişini kapatıp açmamıza yarıyor.

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

            #region ComboBox Aracı
            // Çoklu seçim kutusu olarak kullanılan araçtır.
            // Listede istenilen değerlerden herhangi birini seçtirmek için kullanılır.
            // Properties => DropDownStyle => DropDownList => Combobox için dışarıdan veri girişini engeller, sadece seçim yapılabilir.
            //                              => Simple => Listesiz kullanım sunmakta, pek tercih edilebilir değil.
            #endregion // ComboBox Aracı

            #region ListBox Aracı
            // Verilerin listelenmesi için kullanılır.
            // Yapı olarak comboBox aracına benziyor.
            // Listelenecek veriler items.Add komutu kullanılarak ListBox aracına eklenir.
            // listBox1.Items.Add("PosteSQL");
            #endregion // ListBox Aracı

            #region Maskedtextbox Aracı
            // Maskeli metin kutusu anlamına gelmektedir.
            // Telefon numarası, e-posta gibi alanlar için kutucuğu maskeler.

            // Özel Tanımlama
            // A: Alfabetik karakter veya sayısal karakter kabul eder.
            // L: Yalnızca alfabetik bir karakter kabul eder.
            // 0: Yalnızca sayısal bir karakter kabul eder.
            // C: Herhangi bir karakter kabul eder(opsiyonel olarak boş bırakılabilir).
            // \: Takip eden karakteri sabit metin olarak kabul eder(örneğin \M harfi 'M' olarak görünür).
            // TC yazılı 11 haneli maske tanımlaması.
            // \T\C00000000000
            #endregion // Maskedtextbox Aracı

            #region Picturebox Aracı
            // Formda resim kutusu olarak kullanılır.
            // Forma resim dosyaları ekleyip görüntüleyebilmektedir.

            // Choose Image = Resim Seç
            //  Resourse Context = Yerel Kaynaktan Resim Seç
            // Import = Resmi dahil et..
            //  Project Resource File = Projede var olan resmi seç
            // Size Mode = Resmin Modu
            // StretchImage => Resmi picturebox aracına göre tam kaplar.
            // Dock in Parent Container = içeriğin tamamını kapla, formun tamamını kaplar
            #endregion // Picturebox Aracı

            #region Groupbox Aracı
            // Araçları gruplandırmak için kullanılan form aracıdır.
            // Amaç özellikle birbirleriyle ilişkili olan bileşenleri bir arada tutmaktır.
            #endregion // Groupbox Aracı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buraya butona tıklandığında (_Click) ne olacağını yazıyoruz.

            //label6.Text = "Kocaeli"; // Butona tıklanıldığında label6 nın metnini Kocaeli olarak değiştirecektir.
            label8.Text = textBox1.Text; // Butona tıklanıldığında textBox1 de yer alan metin label8 e atanacaktır.
            // textBox1.Text = "Veri Girişi" TextBox aracına dışarıdan da veri girişi gerçekleştirilebilir.
            label6.Text = comboBox1.Text; // comboBox1 de seçilen değer label6 a atanacaktır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("JavaScript");
            listBox1.Items.Add("PosteSQL");
            comboBox1.Items.Add("Kayseri");
            listBox1.Items.Add(textBox1.Text); // textBox1 de ki veriyi listBox1 e Items parametresi altında ekledik. (Add)
        }
    }
}
