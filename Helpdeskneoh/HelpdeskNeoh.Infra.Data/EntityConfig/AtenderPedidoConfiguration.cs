using HelpdeskNeoh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;


namespace HelpdeskNeoh.Infra.Data.EntityConfig
{
    public class AtenderPedidoConfiguration : EntityTypeConfiguration<AtenderPedido>
    {
        public AtenderPedidoConfiguration()
        {
            HasKey(p => p.AtenderPedidoId);

            





        }


    }
}
