namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusCodeWebService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StatusCodeWebService",
                c => new
                    {
                        StatusCodeWebServiceId = c.Int(nullable: false, identity: true),
                        Accion = c.String(nullable: false, maxLength: 255),
                        Usuario = c.String(nullable: false, maxLength: 255),
                        Url = c.String(nullable: false, maxLength: 500),
                        PropietarioServicioWeb = c.String(nullable: false, maxLength: 100),
                        FechaRegistro = c.DateTime(nullable: false),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StatusCodeWebServiceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StatusCodeWebService");
        }
    }
}
