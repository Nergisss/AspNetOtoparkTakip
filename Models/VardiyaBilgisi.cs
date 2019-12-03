using System;
using OtoparkTakip.Models;
using System.ComponentModel.DataAnnotations;

namespace OtoparkTakip.Models
{
    public class VardiyaBilgisi
    {
        public int vardiyaID{get;set;}
        public int plakaNo{get;set;}
        [DataType(DataType.Date)]
        public DateTime girisTarihi { get; set; }
        [DataType(DataType.Time)]
        public DateTime girisSaati { get; set; }
        [DataType(DataType.Date)]
        public DateTime cikisTarihi { get; set; }
        [DataType(DataType.Time)]
        public DateTime cikisSaati { get; set; }
        [DataType(DataType.Time)]
        public DateTime gecenSüre { get; set; }
        public int sureID{get;set;}
        public virtual EkUcretBilgisi EkUcretBilgisi{get;set;}

    }
}