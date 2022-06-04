using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IFeedbackServices
    {
        IEnumerable<Feedback> GetListFeedback();
        Feedback AddNewFeedBack();
    }
}
