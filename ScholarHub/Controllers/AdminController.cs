using Microsoft.AspNetCore.Mvc;

namespace ScholarHub.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
