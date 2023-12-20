using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistik sayfası";

            return View();
        }
    }
}
