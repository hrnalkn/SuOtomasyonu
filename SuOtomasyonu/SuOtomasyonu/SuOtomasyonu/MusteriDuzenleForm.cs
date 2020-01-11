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
    public partial class MusteriDuzenleForm : Form
    {
        string ad, soyad, tel, adres;

        private void MusteriDuzenleForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ad;
            textBox2.Text = soyad;
            textBox3.Text = tel;
            textBox4.Text = adres;
        }

        int musteriID;
        public MusteriDuzenleForm(int musteriID, string ad, string soyad,string tel, string adres)
        {
            InitializeComponent();
            this.ad = ad;
            this.soyad = soyad;
            this.tel = tel;
            this.adres = adres;
            this.musteriID = musteriID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriModel ml = new MusteriModel();
            
            ml.MusteriID = musteriID;
            ml.Ad = textBox1.Text;
            ml.Soyad = textBox2.Text;
            ml.Telefon = textBox3.Text;
            ml.Adres = textBox4.Text;
            Musteriler m = new Musteriler();
            m.MusteriID = ml.MusteriID;
            m.Ad = ml.Ad;
            m.Soyad = ml.Soyad;
            m.Telefon = ml.Telefon;
            m.Adres = ml.Adres;
            Helper.MusteriUpdate(m);
            Form1 f1 = new Form1();
            f1.Refresh();
        }
    }
}
