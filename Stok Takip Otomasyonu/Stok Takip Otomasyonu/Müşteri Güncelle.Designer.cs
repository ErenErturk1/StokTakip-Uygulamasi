namespace Stok_Takip_Otomasyonu
{
    partial class Müşteri_Güncelle
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
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
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
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.tblMusteriKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblMusteriKayitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(247, 416);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(235, 24);
            this.txtTc.TabIndex = 4;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(86, 602);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 83;
            this.label8.Text = "Müşterinin Kodu=";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Location = new System.Drawing.Point(247, 598);
            this.txtKod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKod.MaxLength = 10;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(235, 24);
            this.txtKod.TabIndex = 8;
            this.txtKod.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "T.C. Kimlik Numarası=";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btngüncel
            // 
            this.btngüncel.BackColor = System.Drawing.Color.White;
            this.btngüncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncel.Location = new System.Drawing.Point(258, 648);
            this.btngüncel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngüncel.Name = "btngüncel";
            this.btngüncel.Size = new System.Drawing.Size(195, 84);
            this.btngüncel.TabIndex = 9;
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
            this.label5.Location = new System.Drawing.Point(74, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Müşterinin Soyadı=";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Müşterinin Adı=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 40);
            this.label2.TabIndex = 78;
            this.label2.Text = "Lütfen Müşterinin Değiştirmek İstediğiniz Bilgisini \r\nDiğer Bilgileriyle Birlikte" +
    " Yazın:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(247, 371);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.MaxLength = 11;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(235, 24);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(247, 326);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(235, 24);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Müşteri Kodu=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearch.Location = new System.Drawing.Point(385, 209);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtsearch.Location = new System.Drawing.Point(117, 228);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.MaxLength = 10;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(235, 24);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(247, 461);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.MaxLength = 13;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(235, 24);
            this.txtTel.TabIndex = 5;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(75, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Telefon Numarası=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(247, 506);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(235, 24);
            this.txtMail.TabIndex = 6;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(156, 510);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 87;
            this.label6.Text = "E-Maili=";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(78, 557);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 89;
            this.label9.Text = "Müşterinin Adresi=";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(247, 553);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(235, 24);
            this.txtAdres.TabIndex = 7;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
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
            this.telDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(599, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1446, 1017);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "Müşteri İsim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.ReadOnly = true;
            this.isimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isimDataGridViewTextBoxColumn.Width = 150;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Müşteri Soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyisimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyisimDataGridViewTextBoxColumn.Width = 150;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Müşteri T.C";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 150;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Müşteri Telefon No";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telDataGridViewTextBoxColumn.Width = 150;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Müşteri E-Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mailDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Müşteri Adresi";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adresDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Müşteri Kodu";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kodDataGridViewTextBoxColumn.Width = 130;
            // 
            // tblMusteriKayitBindingSource
            // 
            this.tblMusteriKayitBindingSource.DataMember = "tblMusteriKayit";
            this.tblMusteriKayitBindingSource.DataSource = this.stokTakipOtomasyonuDataSet;
            // 
            // stokTakipOtomasyonuDataSet
            // 
            this.stokTakipOtomasyonuDataSet.DataSetName = "StokTakipOtomasyonuDataSet";
            this.stokTakipOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1885, 968);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblMusteriKayitTableAdapter
            // 
            this.tblMusteriKayitTableAdapter.ClearBeforeFill = true;
            // 
            // Müşteri_Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1539, 938);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKod);
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
            this.Name = "Müşteri_Güncelle";
            this.Text = "Müşteri Güncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Müşteri_Güncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKod;
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
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private StokTakipOtomasyonuDataSet stokTakipOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblMusteriKayitBindingSource;
        private StokTakipOtomasyonuDataSetTableAdapters.tblMusteriKayitTableAdapter tblMusteriKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
    }
}