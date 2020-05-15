namespace HelpdeskNeoh.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AtenderPedido",
                c => new
                    {
                        AtenderPedidoId = c.Int(nullable: false, identity: true),
                        DataAbertura = c.DateTime(nullable: false),
                        DataFechamento = c.DateTime(nullable: false),
                        TipoGravidade = c.Int(nullable: false),
                        TipoTendencia = c.Int(nullable: false),
                        TipoUrgencia = c.Int(nullable: false),
                        DesenvolvedorId = c.Int(nullable: false),
                        PedidoSuporteId = c.Int(nullable: false),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.AtenderPedidoId)
                .ForeignKey("dbo.Usuario", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        CpfUsuario = c.String(nullable: false, maxLength: 11, unicode: false),
                        NmUsuario = c.String(nullable: false, maxLength: 200, unicode: false),
                        EmailUsuario = c.String(nullable: false, maxLength: 40, unicode: false),
                        CelularUsuario = c.String(nullable: false, maxLength: 20, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        SenhaUsuario = c.String(nullable: false, maxLength: 11, unicode: false),
                        HospitalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Desenvolvedor",
                c => new
                    {
                        DesenvolvedorId = c.Int(nullable: false, identity: true),
                        NmDesenvolvedor = c.String(nullable: false, maxLength: 250, unicode: false),
                        CpfDesenvolvedor = c.String(nullable: false, maxLength: 11, unicode: false),
                        EmailDesenvolvedor = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        SnAtivoDev = c.Boolean(nullable: false),
                        AtenderPedidoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DesenvolvedorId);
            
            CreateTable(
                "dbo.Hospital",
                c => new
                    {
                        HospitalId = c.Int(nullable: false, identity: true),
                        CnpjHospital = c.String(nullable: false, maxLength: 14, unicode: false),
                        NmHospital = c.String(nullable: false, maxLength: 100, unicode: false),
                        SnGrupo = c.Boolean(nullable: false),
                        SnAtivo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        TipoSistema = c.Int(nullable: false),
                        PedidoSuporte = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HospitalId);
            
            CreateTable(
                "dbo.PedidoSuporte",
                c => new
                    {
                        PedidoSuporteId = c.Int(nullable: false, identity: true),
                        DataPedido = c.DateTime(nullable: false),
                        TipoChamado = c.Int(nullable: false),
                        TipoUrgencia = c.Int(nullable: false),
                        PerfilUsuario = c.Int(nullable: false),
                        TituloPedido = c.String(nullable: false, maxLength: 300, unicode: false),
                        ObservacaoPedido = c.String(nullable: false, maxLength: 4000, unicode: false),
                        StatusPedido = c.Int(nullable: false),
                        DataEncerramento = c.DateTime(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        HospitalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoSuporteId)
                .ForeignKey("dbo.Hospital", t => t.HospitalId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.HospitalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoSuporte", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.PedidoSuporte", "HospitalId", "dbo.Hospital");
            DropForeignKey("dbo.AtenderPedido", "Usuario_UsuarioId", "dbo.Usuario");
            DropIndex("dbo.PedidoSuporte", new[] { "HospitalId" });
            DropIndex("dbo.PedidoSuporte", new[] { "UsuarioId" });
            DropIndex("dbo.AtenderPedido", new[] { "Usuario_UsuarioId" });
            DropTable("dbo.PedidoSuporte");
            DropTable("dbo.Hospital");
            DropTable("dbo.Desenvolvedor");
            DropTable("dbo.Usuario");
            DropTable("dbo.AtenderPedido");
        }
    }
}
