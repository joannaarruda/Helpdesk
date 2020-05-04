using HelpdeskNeoh.Domain.Enums;
using System;

namespace HelpdeskNeoh.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string CpfUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public TipoUsuario tipoUsuario { get; }
        public Hospital hospital { get; }
        public DateTime DataCadastro { get; set; }




    }
}
