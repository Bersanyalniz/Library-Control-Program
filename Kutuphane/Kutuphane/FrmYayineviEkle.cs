using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class FrmYayineviEkle : Form
    {
        public FrmYayineviEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                var Yayınevi = new Yayinevi
                {
                    Ad = textBox1.Text,
                    Aciklama = textBox2.Text,
                };
                DbHelper.AddYayınevi(Yayınevi);
                Close();
                MessageBox.Show("Kaydınız Oluşturulmuştur");
            }
            else
            {
                MessageBox.Show("Gerekli Değerleri Giriniz");
            }
        }
    }
}
