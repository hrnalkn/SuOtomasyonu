using SuOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SuOtomasyonu.Entity.enums;

namespace SuOtomasyonu.Entity
{
    class Helper
    {
        public static Musteriler MusteriEkle(Musteriler m)
        {

            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {

                db.Musteriler.Add(m);
                if (db.SaveChanges() > 0)
                {
                    return (m);
                }
                else
                {
                    return (m);
                }
            }

        }
        public static bool MusteriUpdate(Musteriler m)
        {
            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {
                db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool MusteriSil(int MusteriID)
        {

            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            { 
                var aa = db.Musteriler.Find(MusteriID);
                db.Musteriler.Remove(aa);

                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
        public static List<Musteriler> GetMusteriList()
        {

            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {

                return db.Musteriler.ToList();

            }

        }
        public static (Siparisler,bool) YeniSiparis(Siparisler s)
        {
            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {
                db.Siparisler.Add(s);
                if (db.SaveChanges() > 0)
                {
                    return (s, true);
                }
                else
                {
                    return (s, false);
                }
            }
        }
        public static bool UpdateSiparis(Siparisler s)
        {
            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SiparisSil(int SiparisID)
        {
            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {
                var siparis = db.Siparisler.Find(SiparisID);
                db.Siparisler.Remove(siparis);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static List<SiparislerModel> GetSiparisList()
        {

            using (SuOtomasyonuEntities1 db = new SuOtomasyonuEntities1())
            {
                
                List<SiparislerModel> siparisListesi = new List<SiparislerModel>();
                var a = db.Siparisler.ToList();
                foreach (Siparisler item in a)
                {
                    SiparislerModel sm = new SiparislerModel();
                    sm.SiparisID = item.SiparisID;
                    sm.MusteriID = item.MusteriID;
                    sm.Ad = item.Musteriler.Ad;
                    sm.Soyad = item.Musteriler.Soyad;
                    sm.Musteriler.Adres = item.Musteriler.Adres;
                    sm.Musteriler.Telefon = item.Musteriler.Telefon;
                    sm.Durum = (SiparisDurumu)item.Durum;
                    sm.Tutar = item.Tutar;
                    siparisListesi.Add(sm);
                    
                }
                return siparisListesi;
            }

        }
       
    }
}
