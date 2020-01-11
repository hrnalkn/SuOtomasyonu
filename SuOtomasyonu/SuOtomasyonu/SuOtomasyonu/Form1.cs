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
using static SuOtomasyonu.Entity.enums;

namespace SuOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1();
            List<Musteriler> musteriListesi = db.Musteriler.ToList();
            foreach (var item in musteriListesi)
            {
                dataGridView1.DataSource = db.Musteriler.ToList();
            }
            List<Siparisler> siparisListesi = db.Siparisler.ToList();

            foreach (var item in siparisListesi)
            {
                dataGridView2.DataSource = Helper.GetSiparisList();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {


            Form2 form = new Form2();
            form.Show();
            SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1();
            dataGridView1.DataSource = db.Musteriler.ToList();

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bu işlem geri alınamaz. Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    MusteriModel ml = new MusteriModel();
                    ml.MusteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    ml.Ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    ml.Soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    ml.Telefon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    ml.Adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Musteriler m = new Musteriler();
                    m.MusteriID = ml.MusteriID;
                    m.Ad = ml.Ad;
                    m.Soyad = ml.Soyad;
                    m.Telefon = ml.Telefon;
                    m.Adres = ml.Adres;
                    Helper.MusteriSil(m.MusteriID);

                    MessageBox.Show("Silme işlemi gerçekleşti.");
                    dataGridView1.DataSource = Helper.GetMusteriList();

                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silmek istediginiz işlemi seçin", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string tel = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                MusteriDuzenleForm mdf = new MusteriDuzenleForm(id, ad, soyad, tel, adres);
                mdf.Show();
                dataGridView1.DataSource = Helper.GetMusteriList();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen silmek istediginiz işlemi seçin", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string tel = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                YeniSiparisForm yeniSiparisForm = new YeniSiparisForm(id, ad, soyad, adres, tel);
                yeniSiparisForm.Show();
                dataGridView2.DataSource = Helper.GetSiparisList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silmek istediginiz işlemi seçin", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnYolaCikti_Click(object sender, EventArgs e)
        {
            try
            {
                Siparisler s = new Siparisler();
                s.SiparisID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                s.MusteriID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                s.Durum = (int)SiparisDurumu.YolaÇıktı;
                s.Tutar = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value);
                Helper.UpdateSiparis(s);
                dataGridView2.DataSource = Helper.GetSiparisList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen geçerli bir sipariş seçimi yapın !\n Lütfen önce sipariş verin.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnSiparisTamamlandi_Click(object sender, EventArgs e)
        {
            try
            {

                Siparisler s = new Siparisler();
                s.SiparisID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                s.MusteriID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                s.Durum = (int)SiparisDurumu.Tamamlandı;
                s.Tutar = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value);
                Helper.UpdateSiparis(s);
                dataGridView2.DataSource = Helper.GetSiparisList();

            }

            catch (Exception)
            {
                
                MessageBox.Show("Lütfen geçerli bir sipariş seçimi yapın !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Helper.GetMusteriList();
            dataGridView2.DataSource = Helper.GetSiparisList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Siparisler s = new Siparisler();
                s.SiparisID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                s.MusteriID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                s.Durum = Convert.ToInt32(dataGridView2.CurrentRow.Cells[5].Value);
                s.Tutar = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value);
                Helper.SiparisSil(s.SiparisID);
                dataGridView2.DataSource = Helper.GetSiparisList();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silmek istediginiz işlemi seçin", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    Siparisler s = new Siparisler();
                    s.SiparisID = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    s.MusteriID = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                    s.Durum = Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
                    s.Tutar = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);

                    Helper.SiparisSil(s.SiparisID);
                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Helper.GetSiparisList();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen silmek istediginiz işlemi seçin" , "HATA !",MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Musteriler> musteriList = Helper.GetMusteriList();
            dataGridView1.DataSource = musteriList.Where(q => q.Ad.ToLower().Contains(textBox1.Text) == true || q.Ad.ToUpper().Contains(textBox1.Text) == true).ToList();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {



        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
