using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskNeoh.Domain.Interfaces
{
    public interface IPedidoSuporte<TPedidoSuporte> where TPedidoSuporte : class
    {
        void Add(TPedidoSuporte obj);
        TPedidoSuporte GetById(int id);
        IEnumerable<TPedidoSuporte> GetAll();
        void Update(TPedidoSuporte obj);


    }
}
