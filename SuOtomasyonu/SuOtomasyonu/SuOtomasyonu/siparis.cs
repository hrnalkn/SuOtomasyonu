using SuOtomasyonu.DAL;
using SuOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuOtomasyonu
{
    public partial class siparis : Form
    {
        int musteriID;
        string ad, tel,soyad, adres;
        Siparisler s = new Siparisler();
        Musteriler m = new Musteriler();

        private void SiparisDuzenleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public siparis(int musteriID, string ad, string soyad, string tel, string adres)
        {
            InitializeComponent();
            
            label2.Text = ad;
            label9.Text =soyad;
            label3.Text = tel;
            label5.Text = adres;

            

            SiparisModel sl = new SiparisModel();
            sl.MusteriID = musteriID;
            sl.Ad= ad;
            sl.Soyad = soyad;
            sl.SiparisID = 0;
            sl.Telefon = tel;
            sl.Adres = adres;

            this.ad = ad;
            this.soyad = soyad;
            this.tel = tel;
            this.adres = adres;
            this.musteriID = musteriID;



        }

        private void siparis_Load(object sender, EventArgs e)
        {
       
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Helper.YeniSiparis(s);
        }
    }
}
