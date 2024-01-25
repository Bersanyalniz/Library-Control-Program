
namespace Kutuphane
{
    partial class FrmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayıneviEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.yayıneviEkleToolStripMenuItem,
            this.kitapAlToolStripMenuItem,
            this.kitapİadeToolStripMenuItem,
            this.üyeEkleToolStripMenuItem,
            this.kitapSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // yayıneviEkleToolStripMenuItem
            // 
            this.yayıneviEkleToolStripMenuItem.Name = "yayıneviEkleToolStripMenuItem";
            this.yayıneviEkleToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.yayıneviEkleToolStripMenuItem.Text = "Yayınevi Ekle";
            this.yayıneviEkleToolStripMenuItem.Click += new System.EventHandler(this.yayıneviEkleToolStripMenuItem_Click);
            // 
            // kitapAlToolStripMenuItem
            // 
            this.kitapAlToolStripMenuItem.Name = "kitapAlToolStripMenuItem";
            this.kitapAlToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kitapAlToolStripMenuItem.Text = "Kitap Al";
            this.kitapAlToolStripMenuItem.Click += new System.EventHandler(this.kitapAlToolStripMenuItem_Click);
            // 
            // kitapİadeToolStripMenuItem
            // 
            this.kitapİadeToolStripMenuItem.Name = "kitapİadeToolStripMenuItem";
            this.kitapİadeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.kitapİadeToolStripMenuItem.Text = "Kitap İade";
            this.kitapİadeToolStripMenuItem.Click += new System.EventHandler(this.kitapİadeToolStripMenuItem_Click);
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // kitapSilToolStripMenuItem
            // 
            this.kitapSilToolStripMenuItem.Name = "kitapSilToolStripMenuItem";
            this.kitapSilToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kitapSilToolStripMenuItem.Text = "Kitap Sil";
            this.kitapSilToolStripMenuItem.Click += new System.EventHandler(this.kitapSilToolStripMenuItem_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(544, 345);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBase";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayıneviEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSilToolStripMenuItem;
    }
}

