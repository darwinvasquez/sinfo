namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablaverbalabreviadoajustes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hecho", "IdComportamiento", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hecho", "IdComportamiento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
