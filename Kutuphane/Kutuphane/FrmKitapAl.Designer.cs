
namespace Kutuphane
{
    partial class FrmKitapAl
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.bsKitap = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.bsUye = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUye)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kitap";
            // 
            // cmbKitap
            // 
            this.cmbKitap.DataSource = this.bsKitap;
            this.cmbKitap.DisplayMember = "Ad";
            this.cmbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(75, 62);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(142, 21);
            this.cmbKitap.TabIndex = 27;
            this.cmbKitap.ValueMember = "KitapId";
            // 
            // bsKitap
            // 
            this.bsKitap.DataSource = typeof(Kutuphane.Kitap);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Üye";
            // 
            // cmbUye
            // 
            this.cmbUye.DataSource = this.bsUye;
            this.cmbUye.DisplayMember = "Ad";
            this.cmbUye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUye.FormattingEnabled = true;
            this.cmbUye.Location = new System.Drawing.Point(75, 22);
            this.cmbUye.Name = "cmbUye";
            this.cmbUye.Size = new System.Drawing.Size(142, 21);
            this.cmbUye.TabIndex = 29;
            this.cmbUye.ValueMember = "UyeId";
            // 
            // bsUye
            // 
            this.bsUye.DataSource = typeof(Kutuphane.Uye);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 30;
            // 
            // FrmKitapAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 249);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbUye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FrmKitapAl";
            this.Text = "FrmKitapAl";
            ((System.ComponentModel.ISupportInitialize)(this.bsKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.BindingSource bsKitap;
        private System.Windows.Forms.BindingSource bsUye;
        private System.Windows.Forms.TextBox textBox1;
    }
}