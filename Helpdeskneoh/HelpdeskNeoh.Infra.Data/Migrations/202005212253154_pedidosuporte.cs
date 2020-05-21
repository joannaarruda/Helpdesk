namespace HelpdeskNeoh.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pedidosuporte : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PedidoSuporte", "DataEncerramento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PedidoSuporte", "DataEncerramento", c => c.DateTime(nullable: false));
        }
    }
}
