using HelpdeskNeoh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskNeoh.Domain.Interfaces
{
    public interface IPedidoSuporteRepository : IRepositoryBase<PedidoSuporte>
    {

        IEnumerable<PedidoSuporte> BuscarPorNome(string nome);


    }
}
