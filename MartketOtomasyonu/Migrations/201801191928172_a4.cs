namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "EklenmeZamani", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.SatisDetaylar", "SatisTarihi", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SatisDetaylar", "SatisTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Urunler", "EklenmeZamani", c => c.DateTime(nullable: false));
        }
    }
}
