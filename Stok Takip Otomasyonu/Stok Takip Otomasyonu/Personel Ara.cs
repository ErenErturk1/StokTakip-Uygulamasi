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
    public partial class Personel_Ara : Form
    {
        public Personel_Ara()
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
                SqlCommand komut = new SqlCommand("select * from tblPersonelKayit where tc Like " + txtsearch.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

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

        private void Personel_Ara_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblPersonelKayit' table. You can move, or remove it, as needed.
            this.tblPersonelKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblPersonelKayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_İşlemleri kabul = new Personel_İşlemleri();
            kabul.Show();
            this.Hide();
        }
    }
}
