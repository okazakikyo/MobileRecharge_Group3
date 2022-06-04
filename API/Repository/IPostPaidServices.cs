using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IPostPaidServices
    {
        bool AddNewPostPaid(PostPaid newPostPaid);
        bool UpdatePostPaid(PostPaid editPostPaid);
    }
}
