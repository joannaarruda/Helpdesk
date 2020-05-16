using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpdeskNeoh.MVC.ViewModels
{
    public class HospitalViewModel
    {
        [Key]
        public int HospitalId { get; set; }

        [Required(ErrorMessage ="Preencha o CNPJ")]
        [MaxLength(14,ErrorMessage ="Valor Máximo {0} Permitido ")]
        public string CnpjHospital { get; set; }

        [Required(ErrorMessage = "Preencha o Nome do Hospital")]
        [MaxLength(200, ErrorMessage = "Valor Máximo {0} Permitido ")]
        [MinLength(3, ErrorMessage = "Valor Máximo {0} Permitido ")]
        public string NmHospital { get; set; }
        public bool SnGrupo { get; set; }
        public bool SnAtivo { get; set; }

        [ScaffoldColumn (false)]
        public DateTime DataCadastro { get; set; }
      
        [Required(ErrorMessage = "Preencha o Tipo do Sistema")]
        public TipoSistema TipoSistema { get; set; }

      //  public int PedidoSuporte { get; set; }


      //  public virtual IEnumerable<Usuario> Usuarios { get; set; }
       // public virtual IEnumerable<PedidoSuporte> PedidoSuportes { get; set; }
    }
}