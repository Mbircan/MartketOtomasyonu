namespace MartketOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SiparisDetaylar", "SiparisTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.SiparisDetaylar", "TeslimTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SiparisDetaylar", "TeslimTarihi");
            DropColumn("dbo.SiparisDetaylar", "SiparisTarihi");
        }
    }
}
