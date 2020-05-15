

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelpdeskNeoh.Domain.Entities
{
    public class Desenvolvedor
    {

    [Key]
    public int DesenvolvedorId { get; set; }
    public string NmDesenvolvedor { get; set; }
    public string CpfDesenvolvedor { get; set; }
    public string EmailDesenvolvedor { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool SnAtivoDev { get; set; }

    public int AtenderPedidoId { get; set; }
    public virtual IEnumerable<AtenderPedido> AtenderPedido { get; set; }


    }
}
