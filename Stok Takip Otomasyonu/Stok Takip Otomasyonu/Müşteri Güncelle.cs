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
    public partial class Müşteri_Güncelle : Form
    {
        public Müşteri_Güncelle()
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

        private void Müşteri_Güncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblMusteriKayit' table. You can move, or remove it, as needed.
            this.tblMusteriKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblMusteriKayit);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtTel.Text = "+90";
        }

        private void btngüncel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtsearch.Text != "") {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE tblMusteriKayit SET isim=@isim,soyisim=@soyisim,tc=@tc,tel=@tel,mail=@mail,adres=@adres,kod=@kod Where kod=@kod1", connection);
                    command.Parameters.AddWithValue("@isim", txtAd.Text);
                    command.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTc.Text);
                    command.Parameters.AddWithValue("@tel", txtTel.Text);
                    command.Parameters.AddWithValue("@mail", txtMail.Text);
                    command.Parameters.AddWithValue("@adres", txtAdres.Text);
                    command.Parameters.AddWithValue("@kod", txtKod.Text);
                    command.Parameters.AddWithValue("@kod1", txtsearch.Text);

                    command.ExecuteNonQuery();

                    DialogResult result = new DialogResult();

                    result = MessageBox.Show("Güncelleme İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (DialogResult.OK == result)
                    {
                        SqlCommand command1 = new SqlCommand("Select * From tblMusteriKayit", connection);
                        SqlDataAdapter adap = new SqlDataAdapter(command1);
                        DataTable table = new DataTable();

                        adap.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    txtAd.Text = "";
                    txtAdres.Text = "";
                    txtKod.Text = "";
                    txtMail.Text = "";
                    txtsearch.Text = "";
                    txtSoyad.Text = "";
                    txtTc.Text = "";
                    txtTel.Text = "+90";
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi", "İşlem Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Müşteriyi Önce Arayın!","Lütfen Arama Yapınız!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
