namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Satislar", "SatisTarihi", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Satislar", "SatisTarihi", c => c.DateTime());
        }
    }
}
