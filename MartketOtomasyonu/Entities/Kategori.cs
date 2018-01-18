using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartketOtomasyonu.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Required]
        [StringLength(25)]
        [Column("KategoriAdı")]
        [Index(IsUnique = true)]
        public string KategoriAdi { get; set; }
        [Column("Açıklama")]
        public string Aciklama { get; set; }
        public decimal KDV { get; set; }
        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();
    }
}
