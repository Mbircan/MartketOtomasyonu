using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    public class SatisDetayViewModel
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Indirim { get; set; } = 0;
        public decimal KDV { get; set; }
    }
}
