﻿using HelpdeskNeoh.Domain.Enums;
using System;
using System.Dynamic;

namespace HelpdeskNeoh.Domain.Entities
{
   public class Hospital
    {

        public int HospitalId { get; set; }
        public string CnpjHospital { get; set; }
        public string NmHospital { get; set; }
        public bool SnGrupo { get; set; }
        public bool SnAtivo { get; set; }
        public DateTime DataCadastro { get; set; }

        public TipoSistema tipoSistema { get;}

    }
}
