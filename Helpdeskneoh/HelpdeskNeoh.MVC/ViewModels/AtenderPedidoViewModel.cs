using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpdeskNeoh.MVC.ViewModels
{
    public class AtenderPedidoViewModel
    {
        [Key]
        public int AtenderPedidoId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataAbertura { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataFechamento { get; set; }
        public TipoGravidade TipoGravidade { get; set; }
        public TipoTendencia TipoTendencia { get; set; }
        public TipoUrgencia TipoUrgencia { get; set; }

        [Required(ErrorMessage = "Preencha o comentário")]
        [MaxLength(5000, ErrorMessage = "O máximo {0} permitido de caractere")]
        public string ComentarioDev { get; set; }

        public int ResGut { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("DesenvolvedorId")]
        public int DesenvolvedorId { get; set; }


        [ForeignKey("PedidoSuporteId")]
        public int PedidoSuporteId { get; set; }

        public virtual IEnumerable<Desenvolvedor> Desenvolvedor { get; set; }
        public virtual IEnumerable<PedidoSuporte> PedidoSuportes { get; set; }

        public virtual PedidoSuporteViewModel PedidoSuporte { get; set; }


    }
}