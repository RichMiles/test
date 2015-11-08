using Microsoft.AspNet.Mvc;
using System;

namespace Neowire.Web.Controllers.Api
{
    [Route("api/revenue")]
    public class RevenueController : Controller
    {
        public RevenueController(IRevenueRepository repository)
        {
            Repository = repository;
        }

        IRevenueRepository Repository { get; set; }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(Repository.GetRevenueLineItems(DateTime.UtcNow, DateTime.UtcNow, "All"));
        }

        //[HttpGet("api/revenue")]
        //public JsonResult Get(
        //    DateTime startDate,
        //    DateTime endDate,
        //    string country,
        //    string pathName = "",
        //    string publisher = "")
        //{
        //    var items = Repository.GetRevenueLineItems(startDate, endDate, country, pathName, publisher);
        //    return new JsonResult(items);
        //}
    }
}
