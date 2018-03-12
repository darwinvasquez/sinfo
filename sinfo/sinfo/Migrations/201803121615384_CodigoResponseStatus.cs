namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodigoResponseStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodigoResponse", "CodigoStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CodigoResponse", "CodigoStatus");
        }
    }
}
