namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Urunler", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunler", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
