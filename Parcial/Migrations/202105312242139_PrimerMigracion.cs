namespace Parcial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreYApellido = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CUIT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Product");
        }       

    }
}
