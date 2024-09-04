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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            Ürün_Ekle ekle=new Ürün_Ekle();
            ekle.Show();
            this.Hide();
        }

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            Müşteri_Ekle ekle=new Müşteri_Ekle();
            ekle.Show();
            this.Hide();
        }

        private void musteriListele_Click(object sender, EventArgs e)
        {
            Müşteri_Listele listele=new Müşteri_Listele();
            listele.Show();
            this.Hide();
        }

        private void urunListele_Click(object sender, EventArgs e)
        {
            Ürün_Listele liste=new Ürün_Listele();
            liste.Show();
            this.Hide();
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            Ürün_Sil sil=new Ürün_Sil();
            sil.Show();
            this.Hide();
        }

        private void musteriSil_Click(object sender, EventArgs e)
        {
            Müşteri_Sil sill=new Müşteri_Sil();
            sill.Show();
            this.Hide();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            Ürün_Güncelle güncelle=new Ürün_Güncelle();
            güncelle.Show();
            this.Hide();
        }

      
        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            Müşteri_Güncelle guncel = new Müşteri_Güncelle();
            guncel.Show();
            this.Hide();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            Ürün_Ara ara = new Ürün_Ara();
            ara.Show();
            this.Hide();
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            Müşteri_Ara ara = new Müşteri_Ara();
            ara.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_İslemleri_Kabul kabul=new Personel_İslemleri_Kabul();
            kabul.Show();
            this.Hide();
        }
    }
}
