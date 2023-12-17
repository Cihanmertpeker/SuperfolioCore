using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace SuperfolioCore.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {    

        readonly FeatureManager featureManager = new(new EfFeatureDal());     

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetlist();
            return View(values);
        }
    }
}
