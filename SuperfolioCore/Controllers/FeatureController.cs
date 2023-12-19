using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Sayfası";

            var values = featureManager.TGetById(1);
            return View(values);
        }


        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Sayfası";
            featureManager.TUpdate(feature);

            return RedirectToAction("Index","Default");
        }


    }

}
