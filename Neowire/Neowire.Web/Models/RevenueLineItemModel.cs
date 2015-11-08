using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neowire.Web.Models
{
    public class RevenueLineItemModel
    {
        public string Country { get; set; }
        public string PathName { get; set; }
        public string Publisher { get; set; }
        public string SubPublisher { get; set; }
        public int AttemptedRegistrations { get; set; }
        public int RejectedRegistrations { get; set; }
        public int GrossRegistrations { get; set; }
        public int NewUsers { get; set; }
        public double Revenue { get; set; }
        public double RevenuePerUser { get; set; }
    }
}
