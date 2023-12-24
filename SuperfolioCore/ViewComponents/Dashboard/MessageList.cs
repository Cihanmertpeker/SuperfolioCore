using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
       

        public IViewComponentResult Invoke()
        {          

            return View();
        }
    
    }
}
