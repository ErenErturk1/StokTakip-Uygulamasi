using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Stok_Takip_Otomasyonu
{
    public partial class Kayıt_Ekranı : Form
    {
        public Kayıt_Ekranı()
        {
            InitializeComponent();
        }

        BaglantiClass bgl = new BaglantiClass();
         private void Kayıt_Ekranı_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtİsim.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtUnvan.Text == "PATRON" || txtUnvan.Text == "STAJYER" || txtUnvan.Text == "ÇALIŞAN")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("Insert Into tblPersonelKayit(isim,soyisim,tc,sifre,unvan) values (@isim,@soyisim,@tc,@sifre,@unvan)", connection);

                    command.Parameters.AddWithValue("@isim", txtİsim.Text);
                    command.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                    command.Parameters.AddWithValue("@tc", txtTc.Text);
                    command.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    command.Parameters.AddWithValue("@unvan", txtUnvan.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Giriş_Ekranı ekran = new Giriş_Ekranı();
                    ekran.Show();
                    this.Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarısız Oldu!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtSifre.Text = "";
                txtSoyisim.Text = "";
                txtTc.Text = "";
                txtUnvan.Text = "";
                txtİsim.Text = "";
            }
            else
            {
                MessageBox.Show("Sevgili Yetkilimiz,Lütfen Unvan Kısmının Karşısına Patron / Çalışan / Stajyer Bölümlerinden Birini Yazınız!","Unvanlar Hakkında");
            }
        }
    }
}
