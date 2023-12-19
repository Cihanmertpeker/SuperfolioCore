using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(X => X.Name).NotEmpty().WithMessage("Proje Adı boş geçilemez");            
            RuleFor(X => X.ProjectUrl).NotEmpty().WithMessage("Proje UrL alanı boş geçilemez");
           // RuleFor(X => X.Price).NotEmpty().WithMessage("Değer alanı boş geçilemez");
            RuleFor(X => X.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakterden oluşmak zorundadır.");
            RuleFor(X => X.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakterden oluşmak zorundadır.");
        }
    }
}
