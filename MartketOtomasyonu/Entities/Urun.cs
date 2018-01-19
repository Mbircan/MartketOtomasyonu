using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        public string BarkodID { get; set; }
        [Key]
        public int UrunID { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Ürün adı 2-40 karakter aralığında olmalıdır)")]
        [Index(IsUnique = true)]
        [Column("Ürün Adı")]
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; } = 0;
        public short Stok { get; set; } = 0;
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;
        public byte[] UrunResmi { get; set; }
        public decimal KDV { get; set; }
        public int KategoriID { get; set; }
        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }

        public virtual List<SatisDetay> SatisDetaylar { get; set; } = new List<SatisDetay>();
    }
}
