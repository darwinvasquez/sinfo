namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creaciontablahechoysusdependencias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoComportamiento",
                c => new
                    {
                        TipoComportamientoId = c.String(nullable: false, maxLength: 40),
                        Descripcion = c.String(maxLength: 255),
                        CodigoPonal = c.Int(nullable: false),
                        PadrePonal = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TipoComportamientoId);
            
            CreateTable(
                "dbo.Barrio",
                c => new
                    {
                        BarrioId = c.String(nullable: false, maxLength: 40),
                        MunicipioId = c.String(maxLength: 40),
                        Tipo = c.String(maxLength: 4),
                        Descripcion = c.String(maxLength: 255),
                        CodigoDane = c.String(maxLength: 255),
                        CodigoPonal = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BarrioId)
                .ForeignKey("dbo.Municipio", t => t.MunicipioId)
                .Index(t => t.MunicipioId);
            
            CreateTable(
                "dbo.Municipio",
                c => new
                    {
                        MunicipioId = c.String(nullable: false, maxLength: 40),
                        DepartamentoId = c.String(maxLength: 40),
                        Descripcion = c.String(maxLength: 255),
                        CodigoDane = c.String(maxLength: 255),
                        CodigoPonal = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MunicipioId)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoId)
                .Index(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        DepartamentoId = c.String(nullable: false, maxLength: 40),
                        PaisId = c.String(maxLength: 40),
                        Descripcion = c.String(maxLength: 255),
                        CodigoDane = c.String(maxLength: 255),
                        CodigoPonal = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DepartamentoId)
                .ForeignKey("dbo.Pais", t => t.PaisId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        PaisId = c.String(nullable: false, maxLength: 40),
                        Descripcion = c.String(maxLength: 255),
                        CodigoDane = c.String(maxLength: 255),
                        CodigoPonal = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaisId);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        LocalidadId = c.String(nullable: false, maxLength: 40),
                        MunicipioId = c.String(maxLength: 40),
                        Descripcion = c.String(maxLength: 255),
                        CodigoDane = c.String(maxLength: 255),
                        CodigoPonal = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LocalidadId)
                .ForeignKey("dbo.Municipio", t => t.MunicipioId)
                .Index(t => t.MunicipioId);
            
            CreateTable(
                "dbo.Fuente",
                c => new
                    {
                        FuenteId = c.String(nullable: false, maxLength: 40),
                        Descripcion = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.FuenteId);
            
            AddColumn("dbo.Hecho", "PaisId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "DepartamentoId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "TituloId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "CapituloId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "ArticuloId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "NumeralId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "LiteralId", c => c.String(maxLength: 40));
            AddColumn("dbo.Hecho", "TipoComportamiento_TipoComportamientoId", c => c.String(maxLength: 40));
            AlterColumn("dbo.Hecho", "Minicoe", c => c.Int(nullable: false));
            CreateIndex("dbo.Hecho", "PaisId");
            CreateIndex("dbo.Hecho", "DepartamentoId");
            CreateIndex("dbo.Hecho", "MunicipioId");
            CreateIndex("dbo.Hecho", "BarrioId");
            CreateIndex("dbo.Hecho", "LocalidadId");
            CreateIndex("dbo.Hecho", "TituloId");
            CreateIndex("dbo.Hecho", "CapituloId");
            CreateIndex("dbo.Hecho", "ArticuloId");
            CreateIndex("dbo.Hecho", "NumeralId");
            CreateIndex("dbo.Hecho", "LiteralId");
            CreateIndex("dbo.Hecho", "ComportamientoId");
            CreateIndex("dbo.Hecho", "FuenteId");
            CreateIndex("dbo.Hecho", "TipoComportamiento_TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "TipoComportamiento_TipoComportamientoId", "dbo.TipoComportamiento", "TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "ArticuloId", "dbo.TipoComportamiento", "TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "BarrioId", "dbo.Barrio", "BarrioId");
            AddForeignKey("dbo.Hecho", "CapituloId", "dbo.TipoComportamiento", "TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "DepartamentoId", "dbo.Departamento", "DepartamentoId");
            AddForeignKey("dbo.Hecho", "FuenteId", "dbo.Fuente", "FuenteId");
            AddForeignKey("dbo.Hecho", "LiteralId", "dbo.TipoComportamiento", "TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "LocalidadId", "dbo.Localidad", "LocalidadId");
            AddForeignKey("dbo.Hecho", "MunicipioId", "dbo.Municipio", "MunicipioId");
            AddForeignKey("dbo.Hecho", "NumeralId", "dbo.TipoComportamiento", "TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "PaisId", "dbo.Pais", "PaisId");
            AddForeignKey("dbo.Hecho", "ComportamientoId", "dbo.TipoComportamiento", "TipoComportamientoId");
            AddForeignKey("dbo.Hecho", "TituloId", "dbo.TipoComportamiento", "TipoComportamientoId");
            DropColumn("dbo.Hecho", "CnpArt");
            DropColumn("dbo.Hecho", "CnpNum");
            DropColumn("dbo.Hecho", "CnpLit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hecho", "CnpLit", c => c.Int(nullable: false));
            AddColumn("dbo.Hecho", "CnpNum", c => c.Int(nullable: false));
            AddColumn("dbo.Hecho", "CnpArt", c => c.Int(nullable: false));
            DropForeignKey("dbo.Hecho", "TituloId", "dbo.TipoComportamiento");
            DropForeignKey("dbo.Hecho", "ComportamientoId", "dbo.TipoComportamiento");
            DropForeignKey("dbo.Hecho", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Hecho", "NumeralId", "dbo.TipoComportamiento");
            DropForeignKey("dbo.Hecho", "MunicipioId", "dbo.Municipio");
            DropForeignKey("dbo.Hecho", "LocalidadId", "dbo.Localidad");
            DropForeignKey("dbo.Hecho", "LiteralId", "dbo.TipoComportamiento");
            DropForeignKey("dbo.Hecho", "FuenteId", "dbo.Fuente");
            DropForeignKey("dbo.Hecho", "DepartamentoId", "dbo.Departamento");
            DropForeignKey("dbo.Hecho", "CapituloId", "dbo.TipoComportamiento");
            DropForeignKey("dbo.Hecho", "BarrioId", "dbo.Barrio");
            DropForeignKey("dbo.Localidad", "MunicipioId", "dbo.Municipio");
            DropForeignKey("dbo.Departamento", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Municipio", "DepartamentoId", "dbo.Departamento");
            DropForeignKey("dbo.Barrio", "MunicipioId", "dbo.Municipio");
            DropForeignKey("dbo.Hecho", "ArticuloId", "dbo.TipoComportamiento");
            DropForeignKey("dbo.Hecho", "TipoComportamiento_TipoComportamientoId", "dbo.TipoComportamiento");
            DropIndex("dbo.Localidad", new[] { "MunicipioId" });
            DropIndex("dbo.Departamento", new[] { "PaisId" });
            DropIndex("dbo.Municipio", new[] { "DepartamentoId" });
            DropIndex("dbo.Barrio", new[] { "MunicipioId" });
            DropIndex("dbo.Hecho", new[] { "TipoComportamiento_TipoComportamientoId" });
            DropIndex("dbo.Hecho", new[] { "FuenteId" });
            DropIndex("dbo.Hecho", new[] { "ComportamientoId" });
            DropIndex("dbo.Hecho", new[] { "LiteralId" });
            DropIndex("dbo.Hecho", new[] { "NumeralId" });
            DropIndex("dbo.Hecho", new[] { "ArticuloId" });
            DropIndex("dbo.Hecho", new[] { "CapituloId" });
            DropIndex("dbo.Hecho", new[] { "TituloId" });
            DropIndex("dbo.Hecho", new[] { "LocalidadId" });
            DropIndex("dbo.Hecho", new[] { "BarrioId" });
            DropIndex("dbo.Hecho", new[] { "MunicipioId" });
            DropIndex("dbo.Hecho", new[] { "DepartamentoId" });
            DropIndex("dbo.Hecho", new[] { "PaisId" });
            AlterColumn("dbo.Hecho", "Minicoe", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Hecho", "TipoComportamiento_TipoComportamientoId");
            DropColumn("dbo.Hecho", "LiteralId");
            DropColumn("dbo.Hecho", "NumeralId");
            DropColumn("dbo.Hecho", "ArticuloId");
            DropColumn("dbo.Hecho", "CapituloId");
            DropColumn("dbo.Hecho", "TituloId");
            DropColumn("dbo.Hecho", "DepartamentoId");
            DropColumn("dbo.Hecho", "PaisId");
            DropTable("dbo.Fuente");
            DropTable("dbo.Localidad");
            DropTable("dbo.Pais");
            DropTable("dbo.Departamento");
            DropTable("dbo.Municipio");
            DropTable("dbo.Barrio");
            DropTable("dbo.TipoComportamiento");
        }
    }
}
