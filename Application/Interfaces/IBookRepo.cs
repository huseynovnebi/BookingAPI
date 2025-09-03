using Application.Models;
using Domain;
using Infrastructure;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBookRepo : IGenericRepository<Home>
    {
        //Here we can specify specific methods for Book 

        Task<ConcurrentDictionary<Home, List<string>>> AvailableHomesRepo(AvailableHomesGet homes,Storage storage);
    }
}
