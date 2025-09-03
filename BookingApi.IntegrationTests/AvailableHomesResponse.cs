using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApi.IntegrationTests
{
    public class AvailableHomesResponse
    {
        public string Status { get; set; }
        public List<HomeDto> Homes { get; set; }
    }
}
