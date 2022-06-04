using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IUserServices
    {
        IEnumerable<User> GetListUser();
        User GetUserById(string userid,string password);
        bool AddUser(User newUser);
        bool UpdateUser(User editUser);
    }
}
