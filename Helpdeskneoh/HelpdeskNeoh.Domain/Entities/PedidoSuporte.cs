using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public Urgencia urgencia { get; }
        public PerfilUsuario perfilUsuario { get; }
        public string TituloPedido { get; set; }
        public string ObservacaoPedido { get; set; }
        public StatusPedido statusPedido { get; }
        public DateTime DataEncerramento { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        



    }
}
