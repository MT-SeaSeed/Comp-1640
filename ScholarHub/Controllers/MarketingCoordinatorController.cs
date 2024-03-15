using Microsoft.AspNetCore.Mvc;

namespace ScholarHub.Controllers
{
    public class MarketingCoordinatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
