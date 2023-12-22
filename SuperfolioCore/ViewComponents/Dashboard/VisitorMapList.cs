using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class VisitorMapList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
