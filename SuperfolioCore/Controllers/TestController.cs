using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
