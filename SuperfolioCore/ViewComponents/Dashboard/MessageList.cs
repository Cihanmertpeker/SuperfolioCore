using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Context context = new();

            return View();
        }
    
    }
}
