
using HelpdeskNeoh.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HelpdeskNeoh.Infra.Data.EntityConfig
{
    public class PedidoSuporteConfiguration : EntityTypeConfiguration<PedidoSuporte>
    {

        public PedidoSuporteConfiguration()
        {

            HasKey(p => p.PedidoSuporteId);

            Property(p => p.TituloPedido)
                .IsRequired()
                .HasMaxLength(300);

            Property(p => p.ObservacaoPedido)
                .IsRequired()
                .HasMaxLength(4000);

          

        }





    }
}
