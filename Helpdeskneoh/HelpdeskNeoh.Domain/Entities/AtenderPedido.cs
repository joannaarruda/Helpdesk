﻿
using HelpdeskNeoh.Domain.Enums;
using System;
using System.Collections.Generic;

namespace HelpdeskNeoh.Domain.Entities
{
   public class AtenderPedido
    {
        public int AtenderPedidoId { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set;}
        public TipoGravidade TipoGravidade { get; set; }
        public TipoTendencia TipoTendencia { get; set; }
        public TipoUrgencia TipoUrgencia { get; set; }

        public string ComentarioDev { get; set; }

        public int ResGut { get; set; }
        public Usuario Usuario { get; set; }      
        
        public int DesenvolvedorId { get; set; }
        public int PedidoSuporteId { get; set; }

        public virtual Desenvolvedor Desenvolvedor { get; set; }
        public virtual PedidoSuporte PedidoSuporte { get; set; }

 
        public int GetResGut(TipoGravidade gravidade, TipoTendencia tendencia, TipoUrgencia urgencia)
        {
            return ((int)gravidade * (int)tendencia * (int)urgencia);
        }



    }
}
