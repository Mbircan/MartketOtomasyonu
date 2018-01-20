using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.Entities
{
    [Table("SatisDetaylar")]
    public class SatisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SatisID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Indirim { get; set; } = 0;
        public decimal KDV { get; set; }

        [ForeignKey("SatisID")]
        public virtual Satis Satis { get; set; }
        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }
    }
}
