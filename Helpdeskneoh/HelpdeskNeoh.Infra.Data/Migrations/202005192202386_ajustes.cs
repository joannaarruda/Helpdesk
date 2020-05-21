namespace HelpdeskNeoh.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.AtenderPedido", "DesenvolvedorId");
            CreateIndex("dbo.AtenderPedido", "PedidoSuporteId");
            AddForeignKey("dbo.AtenderPedido", "DesenvolvedorId", "dbo.Desenvolvedor", "DesenvolvedorId");
            AddForeignKey("dbo.AtenderPedido", "PedidoSuporteId", "dbo.PedidoSuporte", "PedidoSuporteId");
            DropColumn("dbo.Desenvolvedor", "AtenderPedidoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Desenvolvedor", "AtenderPedidoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AtenderPedido", "PedidoSuporteId", "dbo.PedidoSuporte");
            DropForeignKey("dbo.AtenderPedido", "DesenvolvedorId", "dbo.Desenvolvedor");
            DropIndex("dbo.AtenderPedido", new[] { "PedidoSuporteId" });
            DropIndex("dbo.AtenderPedido", new[] { "DesenvolvedorId" });
        }
    }
}
