using Application.Interfaces;
using Application.Models;
using Domain;
using Infrastructure;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class BookRepo : IBookRepo
    {

        public async Task<ConcurrentDictionary<Home, List<string>>> AvailableHomesRepo(AvailableHomesGet homes,Storage storage)
        {
            string startdate = homes.startDate.ToString("yyyy-MM-dd");
            string enddate = homes.endDate.ToString("yyyy-MM-dd");

            int daydifference = homes.endDate.DayNumber - homes.startDate.DayNumber;

            Parallel.ForEach(storage.homes, home =>
            {
                int startindex = home.Value.IndexOf(startdate);
                int endindex = home.Value.IndexOf(enddate);
                int indexdiff = endindex - startindex;

                if ((startindex == -1 || endindex == -1 || startindex > endindex) || indexdiff != daydifference)
                {
                    storage.homes.TryRemove(home.Key,out _);
                }

            });

            return await Task.FromResult(storage.homes);
        }
    }
}
