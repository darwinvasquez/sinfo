namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codigoPonal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoLugar", "CodigoPonal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoLugar", "CodigoPonal");
        }
    }
}
