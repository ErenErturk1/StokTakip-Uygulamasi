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

namespace Stok_Takip_Otomasyonu
{
    public partial class Müşteri_Ekle : Form
    {
        public Müşteri_Ekle()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtAdres.Text != "" && txtKod.Text != "" && txtMail.Text != "" && txtSoyisim.Text != "" && txtTc.Text != "" && txtTel.Text != "" && txtİsim.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("INSERT INTO tblMusteriKayit(isim,soyisim,tc,tel,mail,adres,kod) values (@isim,@soyisim,@tc,@tel,@mail,@adres,@kod)", connection);

                    command.Parameters.AddWithValue("@isim", txtİsim.Text);
                    command.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                    command.Parameters.AddWithValue("@tc", txtTc.Text);
                    command.Parameters.AddWithValue("@tel", txtTel.Text);
                    command.Parameters.AddWithValue("@mail", txtMail.Text);
                    command.Parameters.AddWithValue("@adres", txtAdres.Text);
                    command.Parameters.AddWithValue("@kod", txtKod.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarısız Oldu!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtİsim.Text = "";
                txtTc.Text = "";
                txtSoyisim.Text = "";
                txtTel.Text = "+90";
                txtMail.Text = "";
                txtAdres.Text = "";
                txtKod.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Atlamadan Yeniden Deneyin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Müşteri_Ekle_Load(object sender, EventArgs e)
        {
            txtİsim.Focus();
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtTel.Text = "+90";
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa=new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
