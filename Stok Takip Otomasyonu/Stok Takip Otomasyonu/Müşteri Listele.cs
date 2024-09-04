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
    public partial class Müşteri_Listele : Form
    {
        public Müşteri_Listele()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void Müşteri_Listele_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();  
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblMusteriKayit' table. You can move, or remove it, as needed.
            this.tblMusteriKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblMusteriKayit);

            SqlCommand command = new SqlCommand("select * from tblMusteriKayit", connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adap.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
