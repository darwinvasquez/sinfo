namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipoLugar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoLugar",
                c => new
                    {
                        TipoLugarId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 500),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoLugarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoLugar");
        }
    }
}
