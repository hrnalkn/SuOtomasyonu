//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuOtomasyonu.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparisler
    {
        public int SiparisID { get; set; }
        public int MusteriID { get; set; }
        public int Tutar { get; set; }
        public int Durum { get; set; }
    
        public virtual Musteriler Musteriler { get; set; }
    }
}
