using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperfolioCore.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialManager = new(new EfTestimonalDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetlist();
            return View(values);
        }

    }
}
