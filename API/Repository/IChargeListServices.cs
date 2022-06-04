using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IChargeListServices
    {
        IEnumerable<ChargeList> GetChargeList();
        IEnumerable<ChargeList> GetChargeListByTitle(string title);
        bool AddNewChargeList(ChargeList newChargeList);
        bool UpdateCharge(ChargeList editChargeList);
        bool DeleteChargeList(int id);
    }
}
