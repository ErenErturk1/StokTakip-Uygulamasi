namespace Stok_Takip_Otomasyonu
{
    partial class Personel_İslemleri_Kabul
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(832, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Unvan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(844, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(769, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "T.C Kimlik No:";
            // 
            // txtUnvan
            // 
            this.txtUnvan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnvan.Location = new System.Drawing.Point(915, 509);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(240, 27);
            this.txtUnvan.TabIndex = 15;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(915, 476);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(240, 27);
            this.txtSifre.TabIndex = 14;
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(915, 443);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(240, 27);
            this.txtTc.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(976, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDurum
            // 
            this.btnDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurum.Location = new System.Drawing.Point(1161, 476);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(86, 27);
            this.btnDurum.TabIndex = 22;
            this.btnDurum.Text = "Göster";
            this.btnDurum.UseVisualStyleBackColor = true;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // Personel_İslemleri_Kabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.button1);
            this.Name = "Personel_İslemleri_Kabul";
            this.Text = "Personel İslemleri Kabul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personel_İslemleri_Kabul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDurum;
    }
}