namespace HelpdeskNeoh.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hospital : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hospital", "PedidoSuporte");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hospital", "PedidoSuporte", c => c.Int(nullable: false));
        }
    }
}
