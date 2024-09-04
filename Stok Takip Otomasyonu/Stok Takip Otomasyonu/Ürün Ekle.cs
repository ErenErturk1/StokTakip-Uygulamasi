using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip_Otomasyonu
{
    public partial class Ürün_Ekle : Form
    {
        public Ürün_Ekle()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtUrunAdi.Text != "" && txtTur.Text != "" && txtMiktar.Text != "" && txtKod.Text != "" && txtFiyat.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("INSERT INTO tblUrunKayit(ad,fiyat,miktar,tur,kod) values (@ad,@fiyat,@miktar,@tur,@kod)", connection);

                    command.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                    command.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                    command.Parameters.AddWithValue("@miktar", txtMiktar.Text);
                    command.Parameters.AddWithValue("@tur", txtTur.Text);
                    command.Parameters.AddWithValue("@kod", txtKod.Text);

                    command.ExecuteNonQuery();


                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarısız Oldu!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtFiyat.Text = "";
                txtMiktar.Text = "";
                txtUrunAdi.Text = "";
                txtTur.Text = "";
                txtKod.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Atlamadan Yeniden Deneyin!","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Ürün_Ekle_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtUrunAdi.Focus();
        }
    }
}
