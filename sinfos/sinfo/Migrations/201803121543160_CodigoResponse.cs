namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodigoResponse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodigoResponse",
                c => new
                    {
                        CodigoResponseId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 255),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoResponseId);
            
            AddColumn("dbo.StatusCodeWebService", "CodigoResponseId", c => c.Int(nullable: false));
            CreateIndex("dbo.StatusCodeWebService", "CodigoResponseId");
            AddForeignKey("dbo.StatusCodeWebService", "CodigoResponseId", "dbo.CodigoResponse", "CodigoResponseId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StatusCodeWebService", "CodigoResponseId", "dbo.CodigoResponse");
            DropIndex("dbo.StatusCodeWebService", new[] { "CodigoResponseId" });
            DropColumn("dbo.StatusCodeWebService", "CodigoResponseId");
            DropTable("dbo.CodigoResponse");
        }
    }
}
