using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Experince
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experinceManager = new(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experinceManager.TGetlist();
            return View(values);
        }
    }
}
