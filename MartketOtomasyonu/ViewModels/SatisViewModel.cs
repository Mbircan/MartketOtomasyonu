using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    public class SatisViewModel
    {
        public int SatisID { get; set; }
        public DateTime SatisTarihi { get; set; }       
        public decimal ToplamSiparisTutari { get; set; }
        public string OdemeSekli { get; set; }
    }
}
