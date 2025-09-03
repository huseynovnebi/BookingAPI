using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class AvailableHomesGet
    {
        public DateOnly startDate { get; set; }
        public DateOnly endDate { get; set; }
    }
}
