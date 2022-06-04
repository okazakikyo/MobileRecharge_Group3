using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IOrderDetailServices
    {
        IEnumerable<OrderDetail> GetListOrderDetailByOrderID(string orderID);
        bool AddNewOrderDetail(OrderDetail newOrderDetail);
        bool DeleteOrderDetail(int id);

    }
}
