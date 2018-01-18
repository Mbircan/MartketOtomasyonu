using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    class UrunViewModel
    {
        public string BarkodID { get; set; }
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public short? Stok { get; set; }
        public string KategoriAdi { get; set; }
        public decimal Indirim { get; set; }

        public override string ToString() => $"{KategoriAdi}, {UrunAdi} , {Fiyat:c2}";
    }
}
