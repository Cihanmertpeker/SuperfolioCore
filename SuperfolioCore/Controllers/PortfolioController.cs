using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace SuperfolioCore.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new(new EfPortfolioDal());
        public IActionResult Index()
        {
            

            var values = portfolioManager.TGetlist();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            

            PortfolioValidator validations = new();
            FluentValidation.Results.ValidationResult results = validations.Validate(p);

            if (results.IsValid)
            {
                portfolioManager.Tadd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            var deletedPortfolio = portfolioManager.TGetById(id);
            portfolioManager.TDelete(deletedPortfolio);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
          
            var updatedPortfolio = portfolioManager.TGetById(id);

            return View(updatedPortfolio);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
          

            PortfolioValidator validations = new();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

        }

    }
}
