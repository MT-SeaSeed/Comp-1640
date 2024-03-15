using Microsoft.AspNetCore.Mvc;

namespace ScholarHub.Controllers
{
    public class MarketingManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
