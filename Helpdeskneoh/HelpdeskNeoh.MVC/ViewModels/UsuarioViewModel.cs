using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpdeskNeoh.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        //  public object Hospital;


        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o seu Cpf")]
        [MaxLength(11, ErrorMessage = "O máximo {0} permitido de caractere")]
        public string CpfUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o Nome do Usuário")]
        [MaxLength(200, ErrorMessage = "O máximo {0} permitido de caractere")]
        [MinLength(50, ErrorMessage = "O mínimo {0} de caractere permitido")]
        public string NmUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o E-mail do Usuário")]
        [MaxLength(100, ErrorMessage = "O máximo {0} permitido de caractere")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string EmailUsuario { get; set; }

        [Required(ErrorMessage = "Preencha o Celular do Usuário")]
        [MaxLength(20, ErrorMessage = "O máximo {0} permitido de caractere")]
        public string CelularUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o tipo do Usuário")]
        public TipoUsuario TipoUsuario { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public string SenhaUsuario { get; set; }
        [ForeignKey("HospitalId")]
        public int HospitalId { get; set; }



        public virtual IEnumerable<HospitalViewModel> Hospitais { get; set; }
        public virtual IEnumerable<PedidoSuporteViewModel> PedidoSuportes { get; set; }



    }
}