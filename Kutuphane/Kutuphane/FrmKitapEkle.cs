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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
            ComboDoldur();
        }
        private void ComboDoldur()
        {
            var yayineviList = DbHelper.GetYayineviList();
            bs.DataSource = yayineviList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Gerekli Değerleri Giriniz");
                return;
            }

            var kitap = new Kitap
            {
                YayineviId = (int) comboBox1.SelectedValue,
                Ad = textBox1.Text,
                Yazar = textBox2.Text,
                VerilisTar = dateTimePicker1.Value,
                AlinmaDurum = false,
            };
            DbHelper.AddKitap(kitap);
            Close();
            MessageBox.Show("Kaydınız Oluşturulmuştur");

        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
