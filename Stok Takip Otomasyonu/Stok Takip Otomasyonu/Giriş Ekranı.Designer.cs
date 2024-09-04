namespace Stok_Takip_Otomasyonu
{
    partial class Giriş_Ekranı
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
            this.btngiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.White;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(961, 538);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(149, 55);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(820, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(739, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(882, 495);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(304, 27);
            this.txtsifre.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(882, 462);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(304, 27);
            this.txtTc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(961, 601);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDurum
            // 
            this.btnDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurum.Location = new System.Drawing.Point(1193, 489);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(86, 32);
            this.btnDurum.TabIndex = 9;
            this.btnDurum.Text = "Göster";
            this.btnDurum.UseVisualStyleBackColor = true;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // Giriş_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtTc);
            this.Name = "Giriş_Ekranı";
            this.Text = "Giriş Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Giriş_Ekranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDurum;
    }
}