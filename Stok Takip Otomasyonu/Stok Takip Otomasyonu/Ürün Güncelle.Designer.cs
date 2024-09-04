namespace Stok_Takip_Otomasyonu
{
    partial class Ürün_Güncelle
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
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btngüncel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.tblUrunKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblUrunKayitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1880, 968);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 8;
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
            this.adDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUrunKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(599, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1446, 1017);
            this.dataGridView1.TabIndex = 15;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adDataGridViewTextBoxColumn.Width = 207;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Ürün Fiyatı";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            this.fiyatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fiyatDataGridViewTextBoxColumn.Width = 207;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Ürün Miktarı";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.miktarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.miktarDataGridViewTextBoxColumn.Width = 207;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Ürün Türü";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.ReadOnly = true;
            this.turDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.turDataGridViewTextBoxColumn.Width = 207;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kodDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblUrunKayitBindingSource
            // 
            this.tblUrunKayitBindingSource.DataMember = "tblUrunKayit";
            this.tblUrunKayitBindingSource.DataSource = this.stokTakipOtomasyonuDataSet;
            // 
            // stokTakipOtomasyonuDataSet
            // 
            this.stokTakipOtomasyonuDataSet.DataSetName = "StokTakipOtomasyonuDataSet";
            this.stokTakipOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Location = new System.Drawing.Point(236, 619);
            this.txtKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtKod.MaxLength = 10;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(235, 24);
            this.txtKod.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(124, 623);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürün Kodu=";
            // 
            // txtTur
            // 
            this.txtTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTur.Location = new System.Drawing.Point(236, 574);
            this.txtTur.Margin = new System.Windows.Forms.Padding(4);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(235, 24);
            this.txtTur.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(129, 578);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ürün Türü=";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(236, 529);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(235, 24);
            this.txtMiktar.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(112, 533);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ürün Miktarı=";
            // 
            // btngüncel
            // 
            this.btngüncel.BackColor = System.Drawing.Color.White;
            this.btngüncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncel.Location = new System.Drawing.Point(259, 665);
            this.btngüncel.Margin = new System.Windows.Forms.Padding(4);
            this.btngüncel.Name = "btngüncel";
            this.btngüncel.Size = new System.Drawing.Size(195, 84);
            this.btngüncel.TabIndex = 7;
            this.btngüncel.Text = "Güncelle";
            this.btngüncel.UseVisualStyleBackColor = false;
            this.btngüncel.Click += new System.EventHandler(this.btngüncel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(123, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Fiyatı=\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(140, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün Adı=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürünün Değiştirmek İstediğiniz Bilgisini Giriniz:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(236, 484);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.MaxLength = 11;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(235, 24);
            this.txtFiyat.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(236, 439);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(235, 24);
            this.txtAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 99;
            this.label1.Text = "Ürün Kodu=";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearch.Location = new System.Drawing.Point(380, 322);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(146, 57);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Ara";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearch.Location = new System.Drawing.Point(112, 341);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.MaxLength = 10;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(235, 24);
            this.txtsearch.TabIndex = 0;
            // 
            // tblUrunKayitTableAdapter
            // 
            this.tblUrunKayitTableAdapter.ClearBeforeFill = true;
            // 
            // Ürün_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btngüncel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Name = "Ürün_Güncelle";
            this.Text = "Ürün Güncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ürün_Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btngüncel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private StokTakipOtomasyonuDataSet stokTakipOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblUrunKayitBindingSource;
        private StokTakipOtomasyonuDataSetTableAdapters.tblUrunKayitTableAdapter tblUrunKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
    }
}