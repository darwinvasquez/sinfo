namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrlBaseDos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PermisoServicioWeb",
                c => new
                    {
                        PermisoServicioWebId = c.Int(nullable: false, identity: true),
                        UsuarioAutorizadoId = c.Int(nullable: false),
                        UrlBaseId = c.Int(nullable: false),
                        UrlServicioWebId = c.Int(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PermisoServicioWebId)
                .ForeignKey("dbo.UrlBase", t => t.UrlBaseId, cascadeDelete: true)
                .ForeignKey("dbo.UrlServicioWeb", t => t.UrlServicioWebId, cascadeDelete: true)
                .ForeignKey("dbo.UsuarioAutorizado", t => t.UsuarioAutorizadoId, cascadeDelete: true)
                .Index(t => t.UsuarioAutorizadoId)
                .Index(t => t.UrlBaseId)
                .Index(t => t.UrlServicioWebId);
            
            CreateTable(
                "dbo.UrlBase",
                c => new
                    {
                        UrlBaseId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 255),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UrlBaseId);
            
            CreateTable(
                "dbo.UrlServicioWeb",
                c => new
                    {
                        UrlServicioWebId = c.Int(nullable: false, identity: true),
                        Metodo = c.String(nullable: false, maxLength: 5),
                        Url = c.String(nullable: false, maxLength: 255),
                        NombreServicio = c.String(nullable: false, maxLength: 255),
                        DescripcionServicio = c.String(nullable: false, maxLength: 255),
                        Propietario = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.UrlServicioWebId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PermisoServicioWeb", "UsuarioAutorizadoId", "dbo.UsuarioAutorizado");
            DropForeignKey("dbo.PermisoServicioWeb", "UrlServicioWebId", "dbo.UrlServicioWeb");
            DropForeignKey("dbo.PermisoServicioWeb", "UrlBaseId", "dbo.UrlBase");
            DropIndex("dbo.PermisoServicioWeb", new[] { "UrlServicioWebId" });
            DropIndex("dbo.PermisoServicioWeb", new[] { "UrlBaseId" });
            DropIndex("dbo.PermisoServicioWeb", new[] { "UsuarioAutorizadoId" });
            DropTable("dbo.UrlServicioWeb");
            DropTable("dbo.UrlBase");
            DropTable("dbo.PermisoServicioWeb");
        }
    }
}
