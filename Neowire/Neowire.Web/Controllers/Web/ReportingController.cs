using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Neowire.Web.Controllers
{
    public class ReportingController : Controller
    {
        public ReportingController(IRevenueRepository repository)
        {
            Repository = repository;
        }

        IRevenueRepository Repository { get; set; }

        // GET: /<controller>/
        public IActionResult Revenue()
        {
            return View();
        }

        public IActionResult Offer()
        {
            return View();
        }
    }
}
