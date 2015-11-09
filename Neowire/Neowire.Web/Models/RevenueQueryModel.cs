using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neowire.Web.Models
{
    public class RevenueQueryModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Country { get; set; }
        public string PathName { get; set; }
        public string Publisher { get; set; }
    }
}
