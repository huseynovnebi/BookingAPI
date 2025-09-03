using Domain;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Storage
    {

        public ConcurrentDictionary<Home, List<string>> homes = new ConcurrentDictionary<Home, List<string>>{};
    }
}
