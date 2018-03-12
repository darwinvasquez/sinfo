namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class localidadVigente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Localidad", "Vigente", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Localidad", "Vigente");
        }
    }
}
