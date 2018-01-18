using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.Entities
{
    [Table("SiparisDetaylar")]
    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunID { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public DateTime? TeslimTarihi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Indirim { get; set; } = 0;

        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }
    }
}
