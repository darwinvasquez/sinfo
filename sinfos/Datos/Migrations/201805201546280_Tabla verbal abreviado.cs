namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablaverbalabreviado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hecho",
                c => new
                    {
                        HechoId = c.String(nullable: false, maxLength: 40),
                        Fecha = c.DateTime(nullable: false),
                        IdMunicipio = c.Int(nullable: false),
                        IdBarrio = c.Int(nullable: false),
                        Localidad = c.String(maxLength: 100),
                        DireccionHechos = c.String(maxLength: 2555),
                        IdComportamiento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Apelacion = c.String(maxLength: 2),
                        RelatoHechos = c.String(maxLength: 4000),
                        Mop = c.Int(nullable: false),
                        Mrs = c.Int(nullable: false),
                        Minc = c.Int(nullable: false),
                        Mtpp = c.Int(nullable: false),
                        Msia = c.Decimal(precision: 18, scale: 2),
                        Mtppp = c.Decimal(precision: 18, scale: 2),
                        Minicoe = c.Decimal(precision: 18, scale: 2),
                        Minisoe = c.Decimal(precision: 18, scale: 2),
                        CnpArt = c.Int(nullable: false),
                        CnpNum = c.Int(nullable: false),
                        CnpLit = c.Int(nullable: false),
                        Latitud = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitud = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdTipoLugar = c.Int(nullable: false),
                        Descargos = c.String(maxLength: 255),
                        HoraHechos = c.DateTime(nullable: false),
                        AtiendeApelacion = c.String(maxLength: 2),
                        IdEntidadeRemiteApelac = c.Int(nullable: false),
                        Fuente = c.Int(nullable: false),
                        IdTipoTransp = c.Int(nullable: false),
                        idHechosPonal = c.Int(nullable: false),
                        NumeroExpediente = c.String(maxLength: 255),
                        Vigente = c.Boolean(nullable: false),
                        UsuarioCreacion = c.String(maxLength: 255),
                        FechaCreacion = c.DateTime(nullable: false),
                        MaquinaCreacion = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.HechoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hecho");
        }
    }
}
