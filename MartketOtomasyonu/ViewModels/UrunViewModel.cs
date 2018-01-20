using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    public class UrunViewModel
    {
        public string BarkodID { get; set; }
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public short? Stok { get; set; }
        public string KategoriAdi { get; set; }
        public decimal Indirim { get; set; }
        public decimal KDV { get; set; }
        public byte[] UrunResmi { get; set; }
        public override string ToString() => $"{KategoriAdi}, {UrunAdi} , {Fiyat:c2}";
    }
}
