using System;
namespace OtoparkTakip.Models
{
    public class MusteriGunlukBilgisi
    {
        public char PlakaNo{get;set;}
        public int konumID{get;set;}
        public virtual KonumBilgisi KonumBilgisi{get;set;}
    }
}