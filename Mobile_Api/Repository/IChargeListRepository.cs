using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DbClass;
namespace Mobile_Api.Repository
{
    public interface IChargeListRepository
    {
        Task<IEnumerable<ChargeList>> GetChargeLists();

        Task<IEnumerable<ChargeList>> GetListForU(string target);

        Task<bool> AddChargeList(ChargeList newList);

        Task<ChargeList> EditChargeList(ChargeList editList);

        Task<ChargeList> getCharge(string id);

        Task<bool> DeleteChargeList();
    }
}
