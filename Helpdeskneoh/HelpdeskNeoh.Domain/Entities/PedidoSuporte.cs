using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskNeoh.Domain.Entities
{
    public class PedidoSuporte
    {
        public int PedidoSuporteId { get; set; }
        public DateTime DataPedido { get; set; }
        public TipoChamado tipoChamado { get; }



    }
}
