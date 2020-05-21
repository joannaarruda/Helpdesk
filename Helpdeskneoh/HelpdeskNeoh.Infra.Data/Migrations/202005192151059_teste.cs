namespace HelpdeskNeoh.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AtenderPedido", "ComentarioDev", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.AtenderPedido", "ResGut", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "tipoUsuario", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "tipoUsuario");
            DropColumn("dbo.AtenderPedido", "ResGut");
            DropColumn("dbo.AtenderPedido", "ComentarioDev");
        }
    }
}
