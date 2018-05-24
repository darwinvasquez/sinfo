namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablahechopersonacalidadCnp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalidadPersonaCnp",
                c => new
                    {
                        CalidadPersonaCnpId = c.String(nullable: false, maxLength: 40),
                        HechoId = c.String(maxLength: 40),
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
                .ForeignKey("dbo.Hecho", t => t.HechoId)
                .ForeignKey("dbo.Persona", t => t.PersonaId)
                .Index(t => t.HechoId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Hecho",
                c => new
                    {
                        HechoId = c.String(nullable: false, maxLength: 40),
                        Fecha = c.DateTime(nullable: false),
                        MunicipioId = c.String(maxLength: 40),
                        BarrioId = c.String(maxLength: 40),
                        LocalidadId = c.String(maxLength: 40),
                        DireccionHechos = c.String(maxLength: 255),
                        ComportamientoId = c.String(maxLength: 40),
                        Apelacion = c.String(maxLength: 2),
                        RelatoHechos = c.String(maxLength: 4000),
                        Mop = c.Int(nullable: false),
                        Mrs = c.Int(nullable: false),
                        Minc = c.Int(nullable: false),
                        Mtpp = c.Int(nullable: false),
                        Msia = c.Int(nullable: false),
                        Mtppp = c.Int(nullable: false),
                        Minicoe = c.Decimal(precision: 18, scale: 2),
                        Minisoe = c.Int(nullable: false),
                        CnpArt = c.Int(nullable: false),
                        CnpNum = c.Int(nullable: false),
                        CnpLit = c.Int(nullable: false),
                        Latitud = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitud = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoLugarId = c.String(maxLength: 40),
                        Descargos = c.String(maxLength: 255),
                        HoraHechos = c.DateTime(nullable: false),
                        AtiendeApelacion = c.String(maxLength: 2),
                        EntidadRemiteApelacionId = c.String(maxLength: 40),
                        FuenteId = c.String(maxLength: 40),
                        TipoTranspId = c.String(maxLength: 40),
                        TipoMedidaId = c.String(maxLength: 40),
                        idHechosPonal = c.Int(nullable: false),
                        NumeroExpediente = c.String(maxLength: 255),
                        Vigente = c.Boolean(nullable: false),
                        UsuarioCreacion = c.String(maxLength: 255),
                        FechaCreacion = c.DateTime(nullable: false),
                        MaquinaCreacion = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.HechoId);
            
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
                        NacionalidadId = c.Int(nullable: false),
                        IdPaisReside = c.Int(nullable: false),
                        IdMunicipioReside = c.Int(nullable: false),
                        IdDepartamentoReside = c.Int(nullable: false),
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
            DropForeignKey("dbo.CalidadPersonaCnp", "HechoId", "dbo.Hecho");
            DropIndex("dbo.CalidadPersonaCnp", new[] { "PersonaId" });
            DropIndex("dbo.CalidadPersonaCnp", new[] { "HechoId" });
            DropTable("dbo.Persona");
            DropTable("dbo.Hecho");
            DropTable("dbo.CalidadPersonaCnp");
        }
    }
}
