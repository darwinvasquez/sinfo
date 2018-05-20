namespace sinfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class listaComp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ListaComportamiento", "IdPapa", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ListaComportamiento", "IdTipo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ListaComportamiento", "Orden", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.ListaComportamiento", "IdTitulo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ListaComportamiento", "IdCapitulo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ListaComportamiento", "IdArticulo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ListaComportamiento", "CodigoPonal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ListaComportamiento", "Descripcion", c => c.String(nullable: false, maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ListaComportamiento", "Descripcion", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.ListaComportamiento", "CodigoPonal", c => c.Int(nullable: false));
            DropColumn("dbo.ListaComportamiento", "IdArticulo");
            DropColumn("dbo.ListaComportamiento", "IdCapitulo");
            DropColumn("dbo.ListaComportamiento", "IdTitulo");
            DropColumn("dbo.ListaComportamiento", "Orden");
            DropColumn("dbo.ListaComportamiento", "IdTipo");
            DropColumn("dbo.ListaComportamiento", "IdPapa");
        }
    }
}
