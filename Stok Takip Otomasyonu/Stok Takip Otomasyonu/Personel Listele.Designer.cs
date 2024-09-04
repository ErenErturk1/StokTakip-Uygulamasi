namespace Stok_Takip_Otomasyonu
{
    partial class Personel_Listele
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
            this.tblPersonelKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.tblPersonelKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblPersonelKayitTableAdapter();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 1055);
            this.dataGridView1.TabIndex = 0;
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
            // tblPersonelKayitTableAdapter
            // 
            this.tblPersonelKayitTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Red;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(1885, 968);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(160, 61);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "Personel İsmi";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.ReadOnly = true;
            this.isimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isimDataGridViewTextBoxColumn.Width = 300;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Personel Soyismi";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyisimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyisimDataGridViewTextBoxColumn.Width = 295;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Personel T.C. Numarası";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 295;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Personel Şifresi";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sifreDataGridViewTextBoxColumn.Width = 300;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "Personel Yetkisi";
            this.unvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.ReadOnly = true;
            this.unvanDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unvanDataGridViewTextBoxColumn.Width = 290;
            // 
            // Personel_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel_Listele";
            this.Text = "Personel Listele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personel_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokTakipOtomasyonuDataSet stokTakipOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblPersonelKayitBindingSource;
        private StokTakipOtomasyonuDataSetTableAdapters.tblPersonelKayitTableAdapter tblPersonelKayitTableAdapter;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
    }
}