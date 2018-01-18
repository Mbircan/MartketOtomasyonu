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
                    })
                .PrimaryKey(t => t.KategoriID)
                .Index(t => t.KategoriAdı, unique: true);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        BarkodID = c.Long(nullable: false),
                        ÜrünAdı = c.String(name: "Ürün Adı", nullable: false, maxLength: 40),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stok = c.Short(nullable: false),
                        EklenmeZamani = c.DateTime(nullable: false),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.ÜrünAdı, unique: true)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.SiparisDetaylar",
                c => new
                    {
                        SiparisID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.SiparisID, t.UrunID })
                .ForeignKey("dbo.Siparisler", t => t.SiparisID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.SiparisID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        SiparisID = c.Int(nullable: false, identity: true),
                        SiparisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(),
                        TedarikciID = c.Int(nullable: false),
                        KargoFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SiparisID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylar", "SiparisID", "dbo.Siparisler");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropIndex("dbo.SiparisDetaylar", new[] { "UrunID" });
            DropIndex("dbo.SiparisDetaylar", new[] { "SiparisID" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropIndex("dbo.Urunler", new[] { "Ürün Adı" });
            DropIndex("dbo.Kategoriler", new[] { "KategoriAdı" });
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
