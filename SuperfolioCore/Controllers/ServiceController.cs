using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new(new EfServiceDal());

        [HttpGet]
        public IActionResult Index()
        {
            
            var values = serviceManager.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.Tadd(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var deletedService = serviceManager.TGetById(id);
            serviceManager.TDelete(deletedService);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            
            var updatedService = serviceManager.TGetById(id);

            return View(updatedService);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
           
            serviceManager.TUpdate(service);

            return RedirectToAction("Index");
        }
    }
}
