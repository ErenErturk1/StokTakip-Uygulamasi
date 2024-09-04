using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    public partial class Personel_İşlemleri : Form
    {
        public Personel_İşlemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa sayfa = new Anasayfa();
            sayfa.Show();
            this.Hide();
        }

        private void personelEkle_Click(object sender, EventArgs e)
        {
            Personel_Ekle ekle=new Personel_Ekle();
            ekle.Show();
            this.Hide();
        }

        private void personelListele_Click(object sender, EventArgs e)
        {
            Personel_Listele listele=new Personel_Listele();
            listele.Show();
            this.Hide();
        }

        private void personelSil_Click(object sender, EventArgs e)
        {
            Personel_Sil sil=new Personel_Sil();
            sil.Show();
            this.Hide();
        }

        private void personelAra_Click(object sender, EventArgs e)
        {
            Personel_Ara ara=new Personel_Ara();
            ara.Show();
            this.Hide();
        }

        private void personelGüncelle_Click(object sender, EventArgs e)
        {
            Personel_Güncelle güncelle=new Personel_Güncelle();
            güncelle.Show();
            this.Hide();
        }
    }
}
