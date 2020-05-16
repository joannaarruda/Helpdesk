using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskNeoh.Infra.Data.Repositories
{
    public class PedidoSuporteRepository : RespositoryBase<PedidoSuporte>, IPedidoSuporteRepository
    {
        public IEnumerable<PedidoSuporte> BuscarPorNome(string titulopedido)
        {
            return Db.PedidoSuportes.Where(p => p.TituloPedido == titulopedido);
        }
    }
}
