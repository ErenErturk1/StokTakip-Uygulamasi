using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Stok_Takip_Otomasyonu
{
    public partial class Personel_İslemleri_Kabul : Form
    {
        public Personel_İslemleri_Kabul()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Select * From tblPersonelKayit Where tc=@tc And sifre=@sifre ", connection);
                command.Parameters.AddWithValue("@tc", txtTc.Text);
                command.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() && txtUnvan.Text == "PATRON")
                {
                    MessageBox.Show("Giriş Başarılı! Hoş Geldin Patron", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Personel_İşlemleri islem = new Personel_İşlemleri();
                    islem.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız!", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtUnvan.Text != "PATRON" && txtUnvan.Text!="")
                {
                    MessageBox.Show("Giriş İşlemi Başarısız. Personel İşlemlerini Sadece Patronlar Yapabilir!", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adını veya Şifrenizi Kontrol Ediniz!", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Personel_İslemleri_Kabul_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtSifre.PasswordChar == '*')
            {
                btnDurum.Text = "Gizle";
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                btnDurum.Text = "Göster";
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
