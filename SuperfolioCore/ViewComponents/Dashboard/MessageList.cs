﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        AppUserMessageManager appUserMessageManager = new(new EfAppUserMessageDal());

        public IViewComponentResult Invoke()
        {
           var values = appUserMessageManager.GetAppUserMessagewithAppUserService();

            return View(values);
        }
    
    }
}
