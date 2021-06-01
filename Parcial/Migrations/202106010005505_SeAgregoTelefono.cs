namespace Parcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeAgregoTelefono : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Afiliado", "Telefono", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Afiliado", "Telefono");
        }
    }
}
