using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Domain.Enums;
using iTextSharp.tool.xml.html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HelpdeskNeoh.MVC.ViewModels
{
    public class HospitalViewModel
    {
        [Key]
        public int HospitalId { get; set; }

        [Required(ErrorMessage = "Preencha o CNPJ")]
        [MaxLength(14, ErrorMessage = "Valor Máximo {0} Permitido ")]
        [DisplayName ("CNPJ")]
        public string CnpjHospital { get; set; }

        [Required(ErrorMessage = "Preencha o Nome do Hospital")]
        [MaxLength(200, ErrorMessage = "Valor Máximo {0} Permitido ")]
        [MinLength(3, ErrorMessage = "Valor Máximo {0} Permitido ")]

        [DisplayName ("Nome Hospital")]
        public string NmHospital { get; set; }

        [DisplayName ("Hospital Grupo")]
        public bool SnGrupo { get; set; }

        [DisplayName ("Ativo")]
        public bool SnAtivo { get; set; }

       [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

       [Required(ErrorMessage = "Preencha o Tipo do Sistema")]


        [DisplayName("Tipo Sistema")]
        public TipoSistema TipoSistema { get; set; }

        public int PedidoSuporte { get; set; }


         public virtual IEnumerable<Usuario> Usuarios { get; set; }
         public virtual IEnumerable<PedidoSuporte> PedidoSuportes { get; set; }
       

    }
}