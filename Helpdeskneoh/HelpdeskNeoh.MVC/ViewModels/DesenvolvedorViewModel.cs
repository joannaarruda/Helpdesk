﻿using HelpdeskNeoh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelpdeskNeoh.MVC.ViewModels
{
    public class DesenvolvedorViewModel
    {

        [Key]
        public int DesenvolvedorId { get; set; }

        [Required(ErrorMessage = "Preencha o Nome do Desenvolvedor")]
        [MaxLength(200, ErrorMessage = "O máximo {0} permitido de caractere")]
        [MinLength(50, ErrorMessage = "O mínimo {0} de caractere permitido")]
        public string NmDesenvolvedor { get; set; }


        [Required(ErrorMessage = "Preencha o seu Cpf")]
        [MaxLength(11, ErrorMessage = "O máximo {0} permitido de caractere")]
        public string CpfDesenvolvedor { get; set; }
       
        [Required(ErrorMessage = "Preencha o E-mail do Usuário")]
        [MaxLength(100, ErrorMessage = "O máximo {0} permitido de caractere")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string EmailDesenvolvedor { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool SnAtivoDev { get; set; }

        public virtual IEnumerable<AtenderPedidoViewModel> AtenderPedido { get; set; }

        










    }
}