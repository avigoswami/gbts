namespace Gbts.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secount_Set : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "StreatNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "StreatNumber");
        }
    }
}
