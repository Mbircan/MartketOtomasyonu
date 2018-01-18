namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Siparisler", "TedarikciID");
            DropColumn("dbo.Siparisler", "KargoFiyati");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Siparisler", "KargoFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Siparisler", "TedarikciID", c => c.Int(nullable: false));
        }
    }
}
