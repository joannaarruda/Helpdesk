using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Mvc;

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

        public TipoSistema TipoSistema { get; set; }
        
        //public int PedidoSuporte { get; set; }
        

        public virtual IEnumerable <Usuario> Usuarios { get; set; }
        public virtual IEnumerable <PedidoSuporte >PedidoSuportes { get; set; }


       



    public Hospital()
        {
            TipoSistema  p = (TipoSistema)(new Random()).Next(0, 3);
            switch (p)
            {
                case TipoSistema.MV2000:
                    Console.WriteLine("The color is red");
                    break;
                case TipoSistema.SOULMV:
                    Console.WriteLine("The color is green");
                    break;
                case TipoSistema.TASY:
                    Console.WriteLine("The color is blue");
                    break;

                case TipoSistema.AGFA:
                    break;

                case TipoSistema.OUTROS:
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }

        }
    }
}
