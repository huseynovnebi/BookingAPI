using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //It is used for same methods(Create,Get,Delete,Update) of different classes like Booking,Hotel and etc.
        //Within methods(for dbcontext) we use _dbContext.Set<T>()
    }
}
