using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApi.IntegrationTests
{
    public class HomeDto
    {
        public int HomeId { get; set; }
        public string HomeName { get; set; }
        public List<string> AvailableSlots { get; set; }
    }
}
