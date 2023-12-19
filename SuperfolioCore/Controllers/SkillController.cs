using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace SuperfolioCore.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listesi";
            var values = skillManager.TGetlist();
            return View(values);           
        }

        [HttpGet]
        public IActionResult AddSkill() 
        {
            ViewBag.v1 = "Yetenek Ekleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.Tadd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var deletedSkill = skillManager.TGetById(id);
            skillManager.TDelete(deletedSkill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Yetenek Güncelle";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelle";
            var updatedSkill = skillManager.TGetById(id);

            return View(updatedSkill);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            ViewBag.v1 = "Yetenek Güncelle";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelle";
            skillManager.TUpdate(skill);

            return RedirectToAction("Index");
        }
    }
}
