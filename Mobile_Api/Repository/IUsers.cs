using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DbClass;
namespace Mobile_Api.Repository
{
    public interface IUsers
    {
        Task<IEnumerable<User>> GetUsers();

        Task<User> AddUser();

        Task<User> EditUser();

        Task<User> checkLogin(string uname, string upass);
    }
}
