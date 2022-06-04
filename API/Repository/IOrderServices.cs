using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IOrderServices
    {
        IEnumerable<Order> GetListOrder();
        bool AddNewOrder(Order newOrder);
    }
}
