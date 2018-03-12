namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entidad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entidad",
                c => new
                    {
                        EntidadId = c.Int(nullable: false, identity: true),
                        CodigoPonal = c.Int(nullable: false),
                        CodigoTipoEntidad = c.Int(nullable: false),
                        TipoEntidad = c.String(maxLength: 500),
                        Descripcion = c.String(maxLength: 255),
                        Direccion = c.String(maxLength: 255),
                        Correo = c.String(maxLength: 255),
                        Telefono = c.String(maxLength: 255),
                        Celular = c.String(maxLength: 255),
                        Nit = c.String(maxLength: 255),
                        Web = c.String(maxLength: 255),
                        Latitud = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitud = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CodMunicipio = c.Int(nullable: false),
                        Municipio = c.String(maxLength: 50),
                        CodDepartamento = c.Int(nullable: false),
                        Departamento = c.String(maxLength: 50),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EntidadId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entidad");
        }
    }
}
