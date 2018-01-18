using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.ViewModels
{
    public class SiparisViewModel
    {
        public int SiparisID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public decimal ToplamSiparisTutari { get; set; }
        public string OdemeSekli { get; set; }
    }
}
