using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class ProjectList: ViewComponent
    {
        PortfolioManager portfolioManager = new(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetlist();

            return View(values);
        }
    }
}
