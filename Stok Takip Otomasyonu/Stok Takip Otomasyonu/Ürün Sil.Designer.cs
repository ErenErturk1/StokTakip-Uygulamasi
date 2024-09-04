namespace Stok_Takip_Otomasyonu
{
    partial class Ürün_Sil
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
            this.btnsil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsil = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.tblUrunKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblUrunKayitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnsil.Location = new System.Drawing.Point(411, 515);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(148, 57);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Silmek İstediğiniz Ürünün Numarası=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 445);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün No=";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearch.Location = new System.Drawing.Point(411, 445);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(148, 57);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Ara";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsil
            // 
            this.txtsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsil.Location = new System.Drawing.Point(138, 550);
            this.txtsil.Margin = new System.Windows.Forms.Padding(4);
            this.txtsil.MaxLength = 10;
            this.txtsil.Name = "txtsil";
            this.txtsil.Size = new System.Drawing.Size(265, 24);
            this.txtsil.TabIndex = 2;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearch.Location = new System.Drawing.Point(138, 480);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.MaxLength = 10;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(265, 24);
            this.txtsearch.TabIndex = 0;
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
            this.dataGridView1.TabIndex = 7;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ürün Adi";
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
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Red;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(1885, 968);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(160, 61);
            this.btnAnasayfa.TabIndex = 4;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click_1);
            // 
            // tblUrunKayitTableAdapter
            // 
            this.tblUrunKayitTableAdapter.ClearBeforeFill = true;
            // 
            // Ürün_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsil);
            this.Controls.Add(this.txtsearch);
            this.Name = "Ürün_Sil";
            this.Text = "Ürün Sil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ürün_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsil;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnasayfa;
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