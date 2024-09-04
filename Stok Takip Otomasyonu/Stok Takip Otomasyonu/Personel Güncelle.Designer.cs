namespace Stok_Takip_Otomasyonu
{
    partial class Personel_Güncelle
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
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btngüncel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(1885, 958);
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
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(595, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1461, 1017);
            this.dataGridView1.TabIndex = 100;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "Personelin İsmi";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.ReadOnly = true;
            this.isimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isimDataGridViewTextBoxColumn.Width = 207;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Personelin Soyismi";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyisimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyisimDataGridViewTextBoxColumn.Width = 207;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Personelin T.C. Numarası";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 207;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Personelin Şifresi";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sifreDataGridViewTextBoxColumn.Width = 207;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "Personelin Yetkisi";
            this.unvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.ReadOnly = true;
            this.unvanDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unvanDataGridViewTextBoxColumn.Width = 207;
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
            // txtUnvan
            // 
            this.txtUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnvan.Location = new System.Drawing.Point(256, 513);
            this.txtUnvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(235, 24);
            this.txtUnvan.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(83, 517);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 109;
            this.label6.Text = "Personelin Unvanı=";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(256, 468);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.MaxLength = 13;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(235, 24);
            this.txtSifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Personelin Şifresi=";
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(256, 423);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(235, 24);
            this.txtTc.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(59, 427);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 106;
            this.label7.Text = "T.C. Kimlik Numarası=";
            // 
            // btngüncel
            // 
            this.btngüncel.BackColor = System.Drawing.Color.White;
            this.btngüncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncel.Location = new System.Drawing.Point(277, 548);
            this.btngüncel.Margin = new System.Windows.Forms.Padding(4);
            this.btngüncel.Name = "btngüncel";
            this.btngüncel.Size = new System.Drawing.Size(180, 78);
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
            this.label5.Location = new System.Drawing.Point(83, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 18);
            this.label5.TabIndex = 105;
            this.label5.Text = "Personelin Soyadı=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(111, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 104;
            this.label3.Text = "Personelin Adı=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 40);
            this.label2.TabIndex = 103;
            this.label2.Text = "Lütfen Personelin Değiştirmek İstediğiniz Bilgisini \r\nDiğer Bilgileriyle Birlikte" +
    " Yazın:\r\n";
            // 
            // txtSoyad
            // 
            this.txtSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(256, 378);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.MaxLength = 11;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(235, 24);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(256, 333);
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
            this.label1.Location = new System.Drawing.Point(17, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "Personelin T.C. Numarası=";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearch.Location = new System.Drawing.Point(394, 216);
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
            this.txtsearch.Location = new System.Drawing.Point(126, 235);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(235, 24);
            this.txtsearch.TabIndex = 0;
            // 
            // tblPersonelKayitTableAdapter
            // 
            this.tblPersonelKayitTableAdapter.ClearBeforeFill = true;
            // 
            // Personel_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btngüncel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Name = "Personel_Güncelle";
            this.Text = "Personel Güncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personel_Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btngüncel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
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