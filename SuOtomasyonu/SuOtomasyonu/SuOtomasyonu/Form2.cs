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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim())!=true && string.IsNullOrEmpty(textBox2.Text.Trim()) != true && string.IsNullOrEmpty(textBox3.Text.Trim()) != true && string.IsNullOrEmpty(textBox4.Text.Trim()) != true   )
                {
                    MusteriModel m = new MusteriModel();
                    Musteriler musteri = new Musteriler();

                    m.Ad = textBox1.Text;
                    musteri.Ad = m.Ad;
                    m.Soyad = textBox2.Text;
                    musteri.Soyad = m.Soyad;
                    m.Telefon = textBox3.Text;
                    musteri.Telefon = m.Telefon;
                    m.Adres = textBox4.Text;
                    musteri.Adres = m.Adres;

                    Helper.MusteriEkle(musteri);
                    Helper.GetMusteriList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gerekli alanları doğru bir şekilde doldurduğunuzdan emin olup tekrar deneyin!", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silmek istediginiz işlemi seçin", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            



        }
    }
}
