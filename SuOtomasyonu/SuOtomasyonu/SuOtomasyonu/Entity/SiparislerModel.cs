using SuOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SuOtomasyonu.Entity.enums;

namespace SuOtomasyonu.Entity
{
    class SiparislerModel
    {
        public int SiparisID { get; set; }
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Tutar { get; set; }
        public SiparisDurumu Durum { get; set; }

        public Musteriler Musteriler = new Musteriler();
    }
}
