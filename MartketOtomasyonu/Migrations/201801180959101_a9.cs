namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparisler", "OdemeSekli", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparisler", "OdemeSekli");
        }
    }
}
