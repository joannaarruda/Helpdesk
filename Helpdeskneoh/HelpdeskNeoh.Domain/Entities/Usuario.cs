using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;

namespace HelpdeskNeoh.Domain.Entities
{
    public class Usuario
    {
        public object Hospital;

        public int UsuarioId { get; set; }
        public string CpfUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public TipoUsuario tipoUsuario { get; }
        public DateTime DataCadastro { get; set; }
        public string SenhaUsuario { get; set; }

        public int HospitalId {get;set;}
        


        public virtual IEnumerable<Hospital> Hospitais { get; set; }
        public virtual IEnumerable<PedidoSuporte> PedidoSuportes { get; set; }
        
        

    }
}
