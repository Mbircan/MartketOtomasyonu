using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.Entities
{
    [Table("Satislar")]
    public class Satis
    {
        [Key]
        public int SatisID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public string OdemeSekli { get; set; }

        public virtual List<SatisDetay> SatisDetaylar { get; set; }
    }
}
