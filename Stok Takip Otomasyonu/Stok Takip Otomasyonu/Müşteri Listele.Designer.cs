namespace Stok_Takip_Otomasyonu
{
    partial class Müşteri_Listele
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
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSet();
            this.tblMusteriKayitTableAdapter = new Stok_Takip_Otomasyonu.StokTakipOtomasyonuDataSetTableAdapters.tblMusteriKayitTableAdapter();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriKayitBindingSource)).BeginInit();
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
            this.telDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriKayitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 1055);
            this.dataGridView1.TabIndex = 1;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "Müşteri İsim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.ReadOnly = true;
            this.isimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isimDataGridViewTextBoxColumn.Width = 212;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Müşteri Soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyisimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyisimDataGridViewTextBoxColumn.Width = 212;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Müşteri T.C.";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 212;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Müşteri Telefon No";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telDataGridViewTextBoxColumn.Width = 212;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Müşteri E-Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mailDataGridViewTextBoxColumn.Width = 212;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Müşteri Adresi";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adresDataGridViewTextBoxColumn.Width = 212;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Müşteri Kodu";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kodDataGridViewTextBoxColumn.Width = 210;
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
            // tblMusteriKayitTableAdapter
            // 
            this.tblMusteriKayitTableAdapter.ClearBeforeFill = true;
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
            // Müşteri_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Müşteri_Listele";
            this.Text = "Müşteri Listele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Müşteri_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokTakipOtomasyonuDataSet stokTakipOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblMusteriKayitBindingSource;
        private StokTakipOtomasyonuDataSetTableAdapters.tblMusteriKayitTableAdapter tblMusteriKayitTableAdapter;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
    }
}