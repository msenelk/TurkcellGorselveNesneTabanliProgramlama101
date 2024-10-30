using System;
using System.Windows.Forms;
using System.IO;

namespace TurkcellGorselveNesneTabanliProgramlama201
{
    public partial class _01_DosyaIslemleri : Form
    {
        public _01_DosyaIslemleri()
        {
            InitializeComponent();
        }

        private void BtnFolderBrowserDialog_Click_1(object sender, EventArgs e) // Click, tıklandığında anlamında gelmektedir.
        {
            // Folder browser dialog aracı
            // Dosya giriş çıkış işlemlerinde konum seçmek için kullanılan araçtır.
            // 	Dosya türleri gösterilmez sadece konum bilgisi verilir.

            folderBrowserDialog1.ShowDialog(); // Burada butona tıklandığında Folder Browser'ı çalışmasını istiyoruz.
            // Sadece klasörler ve diziler gözükür.
            label1.Text = folderBrowserDialog1.SelectedPath;
            // SelectetPath => Seçilen yol.
        }

        private void BtnOpenFileDialog_Click_1(object sender, EventArgs e)
        {
            // Open file dialog aracı
            // Folder browser aracından farklı olarak sadece klasörleri değil dosyaları da gösteren araçtır.
            // Bazı filtreleme yöntemleri ile sadece istenen türde dosyalar gösterilebilir.

            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
            // FileName kullanılmaktadır.
            // Dosya adıyla birlikte yolu yazdırıyoruz.
        }

        private void BtnSaveFileDialog_Click(object sender, EventArgs e)
        {
            // Form üzerinden herhangi bir dosya türüne kayıt işlemi yapmaktır.
            saveFileDialog1.ShowDialog();
        }

        string belgeYolu, belgeAdi;

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            belgeAdi = txtAd.Text;
            StreamWriter sw = File.CreateText(belgeYolu + "\\" + belgeAdi + ".txt");
            // StreamWriter, metin verisi yazmak için kullanılır
            // System.IO namespace’i altında bulunur.
            MessageBox.Show("Belgeniz başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeYolu = folderBrowserDialog1.SelectedPath;
                txtYol.Text = belgeYolu;
            }

        }
    }
}
