using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    public class SepetViewModel
    {
        public string BarkodID { get; set; }
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public short Stok { get; set; } = 1;
        public short Adet { get; set; } = 1;
        public decimal Fiyat { get; set; } = 0;
        public decimal Indirim { get; set; } = 0;
        public decimal KDV { get; set; }
        public decimal Toplam => Adet * Fiyat * (1 - Indirim)*(1+KDV);
        public decimal KDVTutarı => Toplam - Adet * Fiyat * (1 - Indirim);
        public override string ToString() => $"{UrunAdi} , {Adet}x{Fiyat}+KDV={Toplam:c2}";
    }
}
