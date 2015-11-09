using System;
using System.Collections.Generic;
using Neowire.Web.Models;

namespace Neowire.Web.Controllers
{
    public class TestRevenueRepository : IRevenueRepository
    {
        public IEnumerable<RevenueLineItemModel> GetRevenueLineItems(DateTime startDate, DateTime endDate, string country, string pathName = "", string publisher = "")
        {
            return new RevenueLineItemModel[]
                {
                    new RevenueLineItemModel { AttemptedRegistrations = 1 },
                    new RevenueLineItemModel { AttemptedRegistrations = 600, }
                };
        }

        public IEnumerable<Path> GetPaths()
        {
            return new Path[]
            {
                new Path() { Id = Guid.NewGuid(), Name = "My Path",  }
            };
        }
    }
}
