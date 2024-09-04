namespace Stok_Takip_Otomasyonu
{
    partial class Personel_Sil
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsil = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.tblPersonelKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblPersonelKayitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1892, 966);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(599, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1446, 1015);
            this.dataGridView1.TabIndex = 15;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "Personel İsmi";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.ReadOnly = true;
            this.isimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isimDataGridViewTextBoxColumn.Width = 207;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Personel Soyismi";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyisimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyisimDataGridViewTextBoxColumn.Width = 207;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Personel T.C. Numarası";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 207;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Personel Şifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sifreDataGridViewTextBoxColumn.Width = 207;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "Personel Yetkisi";
            this.unvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.ReadOnly = true;
            this.unvanDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unvanDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblPersonelKayitBindingSource
            // 
            this.tblPersonelKayitBindingSource.DataMember = "tblPersonelKayit";
            this.tblPersonelKayitBindingSource.DataSource = this.stokTakipOtomasyonuDataSet;
            // 
            // stokTakipOtomasyonuDataSet
            // 
            this.stokTakipOtomasyonuDataSet.DataSetName = "StokTakipOtomasyonuDataSet";
            this.stokTakipOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 533);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Silmek İstediğiniz Personelin T.C. Numarası=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel T.C.=";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearch.Location = new System.Drawing.Point(440, 462);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(148, 57);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "Ara";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsil
            // 
            this.txtsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsil.Location = new System.Drawing.Point(142, 570);
            this.txtsil.Margin = new System.Windows.Forms.Padding(4);
            this.txtsil.MaxLength = 11;
            this.txtsil.Name = "txtsil";
            this.txtsil.Size = new System.Drawing.Size(265, 24);
            this.txtsil.TabIndex = 10;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearch.Location = new System.Drawing.Point(142, 497);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.MaxLength = 11;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(265, 24);
            this.txtsearch.TabIndex = 8;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnsil.Location = new System.Drawing.Point(440, 561);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(148, 57);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // tblPersonelKayitTableAdapter
            // 
            this.tblPersonelKayitTableAdapter.ClearBeforeFill = true;
            // 
            // Personel_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsil);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsil);
            this.Name = "Personel_Sil";
            this.Text = "Personel Sil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personel_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsil;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsil;
        private StokTakipOtomasyonuDataSet stokTakipOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblPersonelKayitBindingSource;
        private StokTakipOtomasyonuDataSetTableAdapters.tblPersonelKayitTableAdapter tblPersonelKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
    }
}