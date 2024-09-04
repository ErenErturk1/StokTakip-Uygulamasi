using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Stok_Takip_Otomasyonu
{
    public partial class Giriş_Ekranı : Form
    {
        public Giriş_Ekranı()
        {
            InitializeComponent();
        }
        BaglantiClass bgl=new BaglantiClass();

        private void Giriş_Ekranı_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kayıt_Ekranı ekran=new Kayıt_Ekranı();
            ekran.Show();
            this.Hide();
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command=new SqlCommand("Select * From tblPersonelKayit Where tc=@tc And sifre=@sifre",connection);
                command.Parameters.AddWithValue("@tc",txtTc.Text);
                command.Parameters.AddWithValue("@sifre",txtsifre.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Giriş İşlemi Başarılı!", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Anasayfa ana=new Anasayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Boş Bırakmayınız!", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adını veya Şifrenizi Kontrol Ediniz!", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtsifre.PasswordChar == '*')
            {
                btnDurum.Text = "Gizle";
                txtsifre.PasswordChar = '\0';
            }
            else
            {
                btnDurum.Text = "Göster";
                txtsifre.PasswordChar = '*';
            }
        }
    }
}
