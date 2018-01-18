using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.Entities
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int SiparisID { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public DateTime? TeslimTarihi { get; set; }
        public string OdemeSekli { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; }
    }
}
