using Microsoft.AspNetCore.Mvc;

namespace ScholarHub.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
