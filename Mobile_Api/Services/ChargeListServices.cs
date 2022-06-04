using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbClass;
using Mobile_Api.Repository;
namespace Mobile_Api.Services
{
    public class ChargeListServices : IChargeListRepository
    {
        Data.DatabaseContext context = new Data.DatabaseContext();
        public ChargeListServices() { }

        public async Task<bool> AddChargeList(ChargeList newList)
        {
            var list = context.ChargeLists.AddAsync(newList);
            await context.SaveChangesAsync();
            return true;
        }

        public Task<bool> DeleteChargeList()
        {
            throw new NotImplementedException();
        }

        public Task<ChargeList> EditChargeList()
        {
            throw new NotImplementedException();
        }

        public async Task<ChargeList> getCharge(string id)
        {
            int uid = int.Parse(id);
            return await context.ChargeLists.FindAsync(uid);
        }

        public async Task<IEnumerable<ChargeList>> GetChargeLists()
        {
            var list = context.ChargeLists.ToList();
            return list;
        }

        public Task<IEnumerable<ChargeList>> GetListForU(string target)
        {
            throw new NotImplementedException();
        }
    }
}
