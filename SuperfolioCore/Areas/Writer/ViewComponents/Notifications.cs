using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SuperfolioCore.Areas.Writer.ViewComponents
{
    public class Notifications:ViewComponent
    {
        AnnouncementManager announcementManager = new(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetlist().Take(5).ToList();
            return View(values);
        }
    }
}
