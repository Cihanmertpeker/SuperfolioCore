using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillManager = new(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetlist();
            return View(values);
        }
    }
}
