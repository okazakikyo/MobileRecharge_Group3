using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DbClass;
namespace Mobile_Api.Repository
{
    public interface IPaypalRepository
    {
        Task<IEnumerable<Paypal>> GetPaypals();

        Task<Paypal> AddPaypal();

        Task<Paypal> GetPaypal(string uid);

        Task<Paypal> EditPaypal();
    }
}
