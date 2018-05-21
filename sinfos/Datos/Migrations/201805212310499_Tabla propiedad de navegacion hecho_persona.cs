namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablapropiedaddenavegacionhecho_persona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalidadPersonaCnp", "HechoId", c => c.String(maxLength: 40));
            CreateIndex("dbo.CalidadPersonaCnp", "HechoId");
            AddForeignKey("dbo.CalidadPersonaCnp", "HechoId", "dbo.Hecho", "HechoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CalidadPersonaCnp", "HechoId", "dbo.Hecho");
            DropIndex("dbo.CalidadPersonaCnp", new[] { "HechoId" });
            DropColumn("dbo.CalidadPersonaCnp", "HechoId");
        }
    }
}
