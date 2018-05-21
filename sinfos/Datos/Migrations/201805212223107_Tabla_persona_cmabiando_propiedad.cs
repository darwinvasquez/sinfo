namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabla_persona_cmabiando_propiedad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persona", "NacionalidadId", c => c.Int(nullable: false));
            DropColumn("dbo.Persona", "idNacionalidad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persona", "idNacionalidad", c => c.Int(nullable: false));
            DropColumn("dbo.Persona", "NacionalidadId");
        }
    }
}
