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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void yayıneviEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmYayineviEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kitapAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapAl();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kitapİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapİade();
            frm.MdiParent = this;
            frm.Show();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmUyeEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKitapSil();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
