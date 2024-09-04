namespace Stok_Takip_Otomasyonu
{
    partial class Ürün_Listele
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
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.tblUrunKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblUrunKayitTableAdapter();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 1055);
            this.dataGridView1.TabIndex = 1;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ürün Adi";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adDataGridViewTextBoxColumn.Width = 300;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Ürün Fiyatı";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            this.fiyatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fiyatDataGridViewTextBoxColumn.Width = 295;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Ürün Miktarı";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.miktarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.miktarDataGridViewTextBoxColumn.Width = 295;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Ürün Türü";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.ReadOnly = true;
            this.turDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.turDataGridViewTextBoxColumn.Width = 300;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kodDataGridViewTextBoxColumn.Width = 290;
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
            // tblUrunKayitTableAdapter
            // 
            this.tblUrunKayitTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Red;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(1885, 968);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(160, 61);
            this.btnAnasayfa.TabIndex = 0;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // Ürün_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ürün_Listele";
            this.Text = "Ürün Listele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ürün_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokTakipOtomasyonuDataSet stokTakipOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblUrunKayitBindingSource;
        private StokTakipOtomasyonuDataSetTableAdapters.tblUrunKayitTableAdapter tblUrunKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}