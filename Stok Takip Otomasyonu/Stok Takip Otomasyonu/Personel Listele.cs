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
    public partial class Personel_Listele : Form
    {
        public Personel_Listele()
        {
            InitializeComponent();
        }
        BaglantiClass bgl = new BaglantiClass();
        private void Personel_Listele_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet.tblPersonelKayit' table. You can move, or remove it, as needed.
            this.tblPersonelKayitTableAdapter.Fill(this.stokTakipOtomasyonuDataSet.tblPersonelKayit);
            
            SqlCommand command = new SqlCommand("Select * From tblPersonelKayit", connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adap.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Personel_İşlemleri kabul = new Personel_İşlemleri();
            kabul.Show();
            this.Hide();
        }
    }
}
