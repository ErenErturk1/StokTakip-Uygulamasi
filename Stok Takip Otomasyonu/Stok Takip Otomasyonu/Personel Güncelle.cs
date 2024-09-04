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
    public partial class Personel_Güncelle : Form
    {
        public Personel_Güncelle()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command1 = new SqlCommand("SELECT * FROM tblPersonelKayit Where tc Like " + txtsearch.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(command1);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Personel Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Personel Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Arama İşlemi Başarısız", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngüncel_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtsearch.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE tblPersonelKayit SET isim=@isim,soyisim=@soyisim,tc=@tc,sifre=@sifre,unvan=@unvan Where tc=@tc1", connection);
                    command.Parameters.AddWithValue("@isim", txtAd.Text);
                    command.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTc.Text);
                    command.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    command.Parameters.AddWithValue("@unvan", txtUnvan.Text);
                    command.Parameters.AddWithValue("@tc1", txtsearch.Text);

                    command.ExecuteNonQuery();

                    DialogResult result = new DialogResult();

                    result = MessageBox.Show("Güncelleme İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (DialogResult.OK == result)
                    {
                        SqlCommand command1 = new SqlCommand("Select * From tblPersonelKayit", connection);
                        SqlDataAdapter adap = new SqlDataAdapter(command1);
                        DataTable table = new DataTable();

                        adap.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtsearch.Text = "";
                    txtSifre.Text = "";
                    txtTc.Text = "";
                    txtUnvan.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi", "İşlem Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Personeli Önce Arayın!", "Lütfen Arama Yapınız!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void Personel_Güncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblPersonelKayit' table. You can move, or remove it, as needed.
            this.tblPersonelKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblPersonelKayit);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_İşlemleri kabul = new Personel_İşlemleri();
            kabul.Show();
            this.Hide();
        }
    }
}
