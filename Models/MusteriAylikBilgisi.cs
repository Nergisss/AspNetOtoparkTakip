using System;
namespace OtoparkTakip.Models
{
    public class MusteriAylikBilgisi
    {
        public char PlakaNo{get;set;}
        public int tcNo{get;set;}
        public string adSoyad{get;set;}
        public string marka{get;set;}
        public string model{get;set;}
        public string renk{get;set;}
        public int konumID{get;set;}
        public virtual KonumBilgisi KonumBilgisi{get;set;}//veri tabanında foreign key olması için ilişki sağlanıyor.
        public int tarifeID{get;set;}
        public virtual TarifeBilgisi  TarifeBilgisi{get;set;}

    }
}