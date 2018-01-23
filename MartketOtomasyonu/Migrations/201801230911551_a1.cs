namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdı = c.String(nullable: false, maxLength: 25),
                        Açıklama = c.String(),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.KategoriID)
                .Index(t => t.KategoriAdı, unique: true);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        BarkodID = c.String(),
                        ÜrünAdı = c.String(name: "Ürün Adı", nullable: false, maxLength: 40),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stok = c.Short(nullable: false),
                        EklenmeZamani = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UrunResmi = c.Binary(),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.ÜrünAdı, unique: true)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.SatisDetaylar",
                c => new
                    {
                        SatisID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        SatisTarihi = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Adet = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.SatisID, t.UrunID })
                .ForeignKey("dbo.Satislar", t => t.SatisID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.SatisID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        SatisTarihi = c.DateTime(precision: 7, storeType: "datetime2"),
                        OdemeSekli = c.String(),
                    })
                .PrimaryKey(t => t.SatisID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatisDetaylar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.SatisDetaylar", "SatisID", "dbo.Satislar");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropIndex("dbo.SatisDetaylar", new[] { "UrunID" });
            DropIndex("dbo.SatisDetaylar", new[] { "SatisID" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropIndex("dbo.Urunler", new[] { "Ürün Adı" });
            DropIndex("dbo.Kategoriler", new[] { "KategoriAdı" });
            DropTable("dbo.Satislar");
            DropTable("dbo.SatisDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
