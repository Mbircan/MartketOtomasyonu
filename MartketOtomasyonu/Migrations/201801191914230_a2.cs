namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Satislar", "SatisTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Satislar", "SatisTarihi", c => c.DateTime(nullable: false));
        }
    }
}
