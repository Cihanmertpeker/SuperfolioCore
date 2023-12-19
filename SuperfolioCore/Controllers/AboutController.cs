using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Sayfası";

            var values = aboutManager.TGetById(1);
            return View(values);
        }


        [HttpPost]
        public IActionResult Index(About about)
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Sayfası";
            aboutManager.TUpdate(about);

            return RedirectToAction("Index", "Default");
        }


    }
}

