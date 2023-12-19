using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
