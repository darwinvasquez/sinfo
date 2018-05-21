namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablapersonaycalidaddepersonacnp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalidadPersonaCnp",
                c => new
                    {
                        CalidadPersonaCnpId = c.String(nullable: false, maxLength: 40),
                        PersonaId = c.String(maxLength: 40),
                        TipoInfractoId = c.Int(nullable: false),
                        MenorEdad = c.Boolean(nullable: false),
                        TipoPoblacion = c.Int(nullable: false),
                        RepresentanteMenor = c.String(maxLength: 40),
                        Vigente = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(),
                        MaquinaCreacion = c.String(),
                    })
                .PrimaryKey(t => t.CalidadPersonaCnpId)
                .ForeignKey("dbo.Persona", t => t.PersonaId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        PersonaId = c.String(nullable: false, maxLength: 40),
                        Nombres = c.String(maxLength: 100),
                        Apellidos = c.String(maxLength: 100),
                        TipoIdentificacion = c.Int(nullable: false),
                        Identificacion = c.String(maxLength: 12),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Telefono = c.String(maxLength: 255),
                        Email = c.String(maxLength: 100),
                        idNacionalidad = c.Int(nullable: false),
                        idPaisReside = c.Int(nullable: false),
                        idMunicipioReside = c.Int(nullable: false),
                        idDepartamentoReside = c.Int(nullable: false),
                        DireccionReside = c.String(),
                        Vigente = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioCreacion = c.String(),
                        MaquinaCreacion = c.String(),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CalidadPersonaCnp", "PersonaId", "dbo.Persona");
            DropIndex("dbo.CalidadPersonaCnp", new[] { "PersonaId" });
            DropTable("dbo.Persona");
            DropTable("dbo.CalidadPersonaCnp");
        }
    }
}
