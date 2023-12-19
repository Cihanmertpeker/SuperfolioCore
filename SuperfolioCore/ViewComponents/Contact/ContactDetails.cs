using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactManager = new(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetlist();
            return View(values);
        }
    }
}
