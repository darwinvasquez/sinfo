namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class localidad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        CodigoPonal = c.Int(nullable: false),
                        CodigoMunicipio = c.Int(nullable: false),
                        Municipio = c.String(nullable: false, maxLength: 100),
                        NombreLocalidad = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.LocalidadId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Localidad");
        }
    }
}
