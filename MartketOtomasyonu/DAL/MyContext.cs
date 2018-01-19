using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MartketOtomasyonu.Entities;

namespace MartketOtomasyonu.DAL
{
    public class MyContext:DbContext
    {
        public MyContext()
           : base("name=MyCon")
        {
        }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<SatisDetay> SatisDetaylar { get; set; }
    }
}
