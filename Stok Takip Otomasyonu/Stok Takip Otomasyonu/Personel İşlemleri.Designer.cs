namespace Stok_Takip_Otomasyonu
{
    partial class Personel_İşlemleri
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
            this.personelGüncelle = new System.Windows.Forms.Button();
            this.personelAra = new System.Windows.Forms.Button();
            this.personelSil = new System.Windows.Forms.Button();
            this.personelListele = new System.Windows.Forms.Button();
            this.personelEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelGüncelle
            // 
            this.personelGüncelle.BackColor = System.Drawing.Color.Yellow;
            this.personelGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelGüncelle.Location = new System.Drawing.Point(1513, 754);
            this.personelGüncelle.Name = "personelGüncelle";
            this.personelGüncelle.Size = new System.Drawing.Size(367, 114);
            this.personelGüncelle.TabIndex = 19;
            this.personelGüncelle.Text = "Persone Güncelle";
            this.personelGüncelle.UseVisualStyleBackColor = false;
            this.personelGüncelle.Click += new System.EventHandler(this.personelGüncelle_Click);
            // 
            // personelAra
            // 
            this.personelAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.personelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelAra.Location = new System.Drawing.Point(1146, 598);
            this.personelAra.Name = "personelAra";
            this.personelAra.Size = new System.Drawing.Size(367, 114);
            this.personelAra.TabIndex = 18;
            this.personelAra.Text = "Personel Ara";
            this.personelAra.UseVisualStyleBackColor = false;
            this.personelAra.Click += new System.EventHandler(this.personelAra_Click);
            // 
            // personelSil
            // 
            this.personelSil.BackColor = System.Drawing.Color.Red;
            this.personelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelSil.Location = new System.Drawing.Point(779, 451);
            this.personelSil.Name = "personelSil";
            this.personelSil.Size = new System.Drawing.Size(367, 114);
            this.personelSil.TabIndex = 17;
            this.personelSil.Text = "Personel Sil";
            this.personelSil.UseVisualStyleBackColor = false;
            this.personelSil.Click += new System.EventHandler(this.personelSil_Click);
            // 
            // personelListele
            // 
            this.personelListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.personelListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelListele.Location = new System.Drawing.Point(412, 318);
            this.personelListele.Name = "personelListele";
            this.personelListele.Size = new System.Drawing.Size(367, 114);
            this.personelListele.TabIndex = 16;
            this.personelListele.Text = "Personel Listele";
            this.personelListele.UseVisualStyleBackColor = false;
            this.personelListele.Click += new System.EventHandler(this.personelListele_Click);
            // 
            // personelEkle
            // 
            this.personelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.personelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelEkle.Location = new System.Drawing.Point(45, 186);
            this.personelEkle.Name = "personelEkle";
            this.personelEkle.Size = new System.Drawing.Size(367, 114);
            this.personelEkle.TabIndex = 15;
            this.personelEkle.Text = "Personel Ekle";
            this.personelEkle.UseVisualStyleBackColor = false;
            this.personelEkle.Click += new System.EventHandler(this.personelEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1885, 968);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 20;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personel_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personelGüncelle);
            this.Controls.Add(this.personelAra);
            this.Controls.Add(this.personelSil);
            this.Controls.Add(this.personelListele);
            this.Controls.Add(this.personelEkle);
            this.Name = "Personel_İşlemleri";
            this.Text = "Personel İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personelGüncelle;
        private System.Windows.Forms.Button personelAra;
        private System.Windows.Forms.Button personelSil;
        private System.Windows.Forms.Button personelListele;
        private System.Windows.Forms.Button personelEkle;
        private System.Windows.Forms.Button button1;
    }
}