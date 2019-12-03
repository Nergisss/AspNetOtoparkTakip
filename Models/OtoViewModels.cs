using System.Collections.Generic;

namespace OtoparkTakip.Models
{
    public class OtoViewModels
    {
        public IEnumerable<EkUcretBilgisi> EkUcretBilgisiItems { get; set; }
        public IEnumerable<KasaBilgisi> KasaBilgisiItems { get; set; }
        public IEnumerable<MusteriAylikBilgisi> MusteriAylikBilgisiItems { get; set; }

        public IEnumerable<MusteriGunlukBilgisi> MusteriGunlukBilgisiItems { get; set; }
        public IEnumerable<TarifeBilgisi> TarifeBilgisiItems { get; set; }
        public IEnumerable<VardiyaBilgisi> VardiyaBilgisiItems { get; set; }

        
    }
}