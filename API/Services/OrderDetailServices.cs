using API.Entities;
using API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class OrderDetailServices : IOrderDetailServices
    {
        public bool AddNewOrderDetail(OrderDetail newOrderDetail)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrderDetail(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetListOrderDetailByOrderID(string orderID)
        {
            throw new NotImplementedException();
        }
    }
}
