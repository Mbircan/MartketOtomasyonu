using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    public class StokViewModel
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public short? Stok { get; set; }

        public override string ToString() => $"{UrunID}, {UrunAdi} , {Stok}";
    }
}
