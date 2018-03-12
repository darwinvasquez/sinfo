namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioAut : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsuarioAutorizado",
                c => new
                    {
                        UsuarioAutorizadoId = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Alcaldia = c.String(nullable: false, maxLength: 255),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFinal = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioAutorizadoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsuarioAutorizado");
        }
    }
}
