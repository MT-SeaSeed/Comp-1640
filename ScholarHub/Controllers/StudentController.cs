using Microsoft.AspNetCore.Mvc;

namespace ScholarHub.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
