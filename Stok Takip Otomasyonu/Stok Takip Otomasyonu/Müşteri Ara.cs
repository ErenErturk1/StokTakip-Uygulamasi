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
    public partial class Müşteri_Ara : Form
    {
        public Müşteri_Ara()
        {
            InitializeComponent();
        }

        BaglantiClass bgl = new BaglantiClass();
       
        private void Müşteri_Ara_Load(object sender, EventArgs e)
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
                SqlCommand komut = new SqlCommand("select * from tblMusteriKayit where kod Like " + txtsearch.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Kişi Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Kişi Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arama İşlemi Başarısız", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            Anasayfa anasayfa=new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
