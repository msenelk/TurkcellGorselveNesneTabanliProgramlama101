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
    public partial class _02_FormIslemleri : Form
    {
        public _02_FormIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // yönlendirilecekFormAdı formNesnesi = new yönlendirilecekForm
            _01_DosyaIslemleri frm  = new _01_DosyaIslemleri();
            // Show açmak için kullanıyoruz
            frm.Show();
            // Diğer formu açınca bu butona tıkladığımız formu gizlemek için
            this.Hide();
        }
    }
}
