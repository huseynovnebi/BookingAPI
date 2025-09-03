using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class GenericRepo<T> : IGenericRepository<T> where T : class
    {
    }
}
