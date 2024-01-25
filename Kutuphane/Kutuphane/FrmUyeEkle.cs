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
    public partial class FrmUyeEkle : Form
    {
        public FrmUyeEkle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                var uye = new Uye
                {
                    Ad = textBox1.Text,
                    Soyad = textBox2.Text,
                    KayitTar = dateTimePicker1.Value,
                };
                DbHelper.AddUye(uye);
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
