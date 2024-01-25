
namespace Kutuphane
{
    partial class FrmKitapSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilisTarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinmaDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.verilisTarDataGridViewTextBoxColumn,
            this.alinmaDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(600, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verilisTarDataGridViewTextBoxColumn
            // 
            this.verilisTarDataGridViewTextBoxColumn.DataPropertyName = "VerilisTar";
            this.verilisTarDataGridViewTextBoxColumn.HeaderText = "VerilisTar";
            this.verilisTarDataGridViewTextBoxColumn.Name = "verilisTarDataGridViewTextBoxColumn";
            this.verilisTarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alinmaDurumDataGridViewCheckBoxColumn
            // 
            this.alinmaDurumDataGridViewCheckBoxColumn.DataPropertyName = "AlinmaDurum";
            this.alinmaDurumDataGridViewCheckBoxColumn.HeaderText = "AlinmaDurum";
            this.alinmaDurumDataGridViewCheckBoxColumn.Name = "alinmaDurumDataGridViewCheckBoxColumn";
            this.alinmaDurumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataSource = typeof(Kutuphane.Kitap);
            // 
            // FrmKitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 386);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKitapSil";
            this.Text = "FrmKitapSil";
            this.Load += new System.EventHandler(this.FrmKitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilisTarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alinmaDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource kitapBindingSource;
    }
}