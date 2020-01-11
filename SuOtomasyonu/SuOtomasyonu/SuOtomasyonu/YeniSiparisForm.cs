using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuOtomasyonu.DAL;
using SuOtomasyonu.Entity;
using static SuOtomasyonu.Entity.enums;

namespace SuOtomasyonu
{
    public partial class YeniSiparisForm : Form
    {
        int id;
        string ad, soyad, adres, tel;

        private void YeniSiparisForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ad;
            textBox2.Text = soyad;
            textBox3.Text = adres;
        }

        public YeniSiparisForm(int id,string ad,string soyad,string adres,string tel)
        {
            InitializeComponent();
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.adres = adres;
            this.tel = tel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text.Trim())!=true)
            {
                Siparisler s = new Siparisler();
                SiparislerModel sm = new SiparislerModel();

                sm.Durum = SiparisDurumu.Hazırlanıyor;
                s.Durum = (int)sm.Durum;
                sm.MusteriID = id;
                s.MusteriID = sm.MusteriID;
                sm.Ad = ad;



                sm.Tutar = Convert.ToInt32(textBox4.Text);
                s.Tutar = sm.Tutar;
                Helper.YeniSiparis(s);
                this.Close();
            }
           
        }
    }
}
