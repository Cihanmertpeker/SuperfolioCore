using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {        

        ServiceManager serviceManager = new(new EfServiceDal());

       public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetlist();

            return View(values);
        }
    }
}
