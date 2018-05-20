namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estadoMedida : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstadoMedida",
                c => new
                    {
                        EstadoMedidaId = c.Int(nullable: false, identity: true),
                        CodigoPonal = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 500),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EstadoMedidaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EstadoMedida");
        }
    }
}
