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
    public partial class Ürün_Güncelle : Form
    {
        public Ürün_Güncelle()
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

                SqlCommand command1 = new SqlCommand("SELECT * FROM tblUrunKayit Where kod Like " + txtsearch.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(command1);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Ürün Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Ürün Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SqlCommand command = new SqlCommand("UPDATE tblUrunKayit SET ad=@ad,fiyat=@fiyat,miktar=@miktar,tur=@tur,kod=@kod Where kod=@kod1", connection);
                    command.Parameters.AddWithValue("@ad", txtAd.Text);
                    command.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                    command.Parameters.AddWithValue("@miktar", txtMiktar.Text);
                    command.Parameters.AddWithValue("@tur", txtTur.Text);
                    command.Parameters.AddWithValue("@kod", txtKod.Text);
                    command.Parameters.AddWithValue("@kod1", txtsearch.Text);

                    command.ExecuteNonQuery();

                    DialogResult result = new DialogResult();

                    result = MessageBox.Show("Güncelleme İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (DialogResult.OK == result)
                    {
                        SqlCommand command1 = new SqlCommand("select * from tblUrunKayit", connection);
                        SqlDataAdapter adap = new SqlDataAdapter(command1);
                        DataTable table = new DataTable();

                        adap.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    txtAd.Text = "";
                    txtFiyat.Text = "";
                    txtKod.Text = "";
                    txtMiktar.Text = "";
                    txtsearch.Text = "";
                    txtTur.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi", "İşlem Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Ürünü Önce Arayın!", "Lütfen Arama Yapınız!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Ürün_Güncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblUrunKayit' table. You can move, or remove it, as needed.
            this.tblUrunKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblUrunKayit);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
