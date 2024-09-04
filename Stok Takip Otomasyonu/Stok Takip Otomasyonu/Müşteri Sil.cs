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
    public partial class Müşteri_Sil : Form
    {
        public Müşteri_Sil()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void Müşteri_Sil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblMusteriKayit' table. You can move, or remove it, as needed.
            this.tblMusteriKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblMusteriKayit);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand komut = new SqlCommand("SELECT * FROM tblMusteriKayit Where kod Like " + txtsearch.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Müşteri Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Müşteri Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Arama İşlemi Başarısız", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Silme İşlemi Başarısız -" + txtsil.Text + "- Numaralı Satırda Müşteri Bulunamamaktadır.", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand komut = new SqlCommand("Delete from tblMusteriKayit where kod=@kod", connection);
                komut.Parameters.AddWithValue("@kod", txtsil.Text);

                komut.ExecuteNonQuery();

                DialogResult result = new DialogResult();
                result = MessageBox.Show("Silme İşlemi Başarılı", "İşlem Başarı İle Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DialogResult.OK == result)
                {
                    SqlCommand command1 = new SqlCommand("select * from tblMusteriKayit", connection);
                    SqlDataAdapter adap = new SqlDataAdapter(command1);
                    DataTable table = new DataTable();

                    adap.Fill(table);

                    dataGridView1.DataSource = table;
                    txtsearch.Text = "";
                }
            }
            catch (Exception h)
            {
                MessageBox.Show("Silme İşlemi Başarısız" + h, "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtsil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
