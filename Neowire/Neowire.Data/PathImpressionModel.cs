using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Neowire.Data
{
    public class PathImpressionModel
    {
        public Guid Id { get; set; }
        public DateTime TimestampUtc { get; set; }
        public double LocalTimeOffsetHours { get; set; }
        public PathLandingPageModel PathLandingPage { get; set; }
        string SingupIpAddress { get; set; }
        string SignupUrl { get; set;}
        string UserAgent { get; set; }
        string Device { get; set; }
    }
}
