using Domain;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public static class StorageData
    {
        public static ConcurrentDictionary<Home, List<string>> GenerateLargeStorage(int hotelCount = 1000)
        {
            var rand = new Random();
            var storage = new ConcurrentDictionary<Home, List<string>>();

            for (int i = 1; i <= hotelCount; i++)
            {
                
                int slotCount = rand.Next(200, 1001);
                var slots = new List<string>(slotCount);
                var startDate = new DateTime(2025, 1, 1);

                for (int j = 0; j < slotCount; j++)
                {
                   
                    var slotDate = startDate.AddDays(j);
                    slots.Add(slotDate.ToString("yyyy-MM-dd"));
                }

                var home = new Home { homeId = i, homeName = $"home{i}" };
                storage[home] = slots;
            }

            //Data created manually for integration testing
            storage.TryAdd(new Home { homeId = 1001, homeName = "home1001" },new List<string> { "2030-01-01","2030-01-02", "2030-01-03" });

            return storage;
        }
    }
}
