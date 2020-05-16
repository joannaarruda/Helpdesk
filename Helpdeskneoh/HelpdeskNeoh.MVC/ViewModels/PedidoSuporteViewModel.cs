using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HelpdeskNeoh.MVC.ViewModels
{
    public class PedidoSuporteViewModel
    {
        [Key]
        public int PedidoSuporteId { get; set; }

        [ScaffoldColumn (false)]
        public DateTime DataPedido { get; set; }
        
        [Required (ErrorMessage = "Informe o tipo de Chamado")]
        public TipoChamado TipoChamado { get; set; }

        [Required(ErrorMessage = "Informe o tipo de Urgência")]
        public TipoUrgencia TipoUrgencia { get; set; }

        [Required(ErrorMessage = "Informe o Perfil do Usuário de onde deseja a melhoria/correção")]
        public PerfilUsuario PerfilUsuario { get; set; }


        [Required(ErrorMessage = "Preencha o Título/Assunto")]
        [MaxLength(200, ErrorMessage = "O máximo {0} permitido de caractere")]
        public string TituloPedido { get; set; }

        [MaxLength(5000, ErrorMessage = "O máximo {0} permitido de caractere")]
        public string ObservacaoPedido { get; set; }
        public StatusPedido StatusPedido { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataEncerramento { get; set; }
        
        [ForeignKey ("UsuarioId")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("HospitalId")]
        public int HospitalId { get; set; }

    }
}