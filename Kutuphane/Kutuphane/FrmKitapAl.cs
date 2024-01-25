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
    public partial class FrmKitapAl : Form
    {
        public FrmKitapAl()
        {
            InitializeComponent();
            ComboDoldur();
            KitapComboDoldur();
        }
        private void ComboDoldur()
        {
            var uyeList = DbHelper.GetUyeList();
            bsUye.DataSource = uyeList;
        }
        private void KitapComboDoldur()
        {
            var kitapList = DbHelper.GetKitapList();
            bsKitap.DataSource = kitapList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbKitap.SelectedItem != null && cmbUye.SelectedItem != null)
            {
                var kitapHareket = new KitapHareket
                {
                    Aciklama = textBox1.Text,
                    UyeId = (int)cmbKitap.SelectedValue,
                    KitapId = (int)cmbUye.SelectedValue,
                    VerilisTar = dateTimePicker1.Value,
                    AlinmaDurum= true,

                };
                DbHelper.AddKitapHareket(kitapHareket);
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
