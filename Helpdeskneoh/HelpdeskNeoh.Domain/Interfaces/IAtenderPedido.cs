using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskNeoh.Domain.Interfaces
{
    public interface IAtenderPedido<TAtenderPedido> where TAtenderPedido : class
    {

        void Add(TAtenderPedido obj);
        TAtenderPedido GetById(int id);
        IEnumerable<TAtenderPedido> GetAll();
        void Update(TAtenderPedido obj);

    }
}
