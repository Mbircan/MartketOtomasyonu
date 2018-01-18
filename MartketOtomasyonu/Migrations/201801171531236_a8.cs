namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "UrunResmi", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "UrunResmi");
        }
    }
}
