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
    public partial class Ürün_Ara : Form
    {
        public Ürün_Ara()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void Ürün_Ara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblUrunKayit' table. You can move, or remove it, as needed.
            this.tblUrunKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblUrunKayit);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
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
                SqlCommand command = new SqlCommand("select * from tblUrunKayit where kod Like " + txtsearch.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(command);

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
    }
}
