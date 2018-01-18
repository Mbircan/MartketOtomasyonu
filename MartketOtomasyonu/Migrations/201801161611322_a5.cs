namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "BarkodID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Urunler", "BarkodID", c => c.Long(nullable: false));
        }
    }
}
