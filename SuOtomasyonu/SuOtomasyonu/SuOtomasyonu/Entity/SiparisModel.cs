using SuOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuOtomasyonu.Entity
{
    class SiparisModel
    {
        public int SiparisID { get; set; }
        public int MusteriID { get; set; }
        public int Tutar { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public int SipairisDurum { get; set; }


        public Musteriler Musteriler { get; set; }


    }
}