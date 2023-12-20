using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Context context = new();

            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Where(x=>x.Status==false).Count();
            ViewBag.v3 = context.Messages.Where(x=>x.Status==true).Count();
            ViewBag.v4 = context.Portfolios.Count();

            return View();
        }
    }
}

