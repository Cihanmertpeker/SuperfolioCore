using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class ToDoListPanel: ViewComponent
    {
        ToDoListManager toDoListManager = new(new EfToDoListDal());

        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetlist();

            return View(values);
        }
    }
}
