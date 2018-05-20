namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ListaComportamiento3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListaComportamiento",
                c => new
                    {
                        ListaComportamientoId = c.Int(nullable: false, identity: true),
                        CodigoPonal = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 500),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ListaComportamientoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListaComportamiento");
        }
    }
}
