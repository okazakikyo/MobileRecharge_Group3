using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IPaypalServices
    {
        bool AddNewPaypal(Paypal newPaypal);
        bool DeletePaypal(string PPID);
    }
}
