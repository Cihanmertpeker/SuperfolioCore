using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager aboutManager = new(new EfAboutDal());


        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetlist();

            return View(values);
        }
    }
}
