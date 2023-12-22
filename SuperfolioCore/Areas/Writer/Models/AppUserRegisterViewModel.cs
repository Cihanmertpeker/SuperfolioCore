using System.ComponentModel.DataAnnotations;

namespace SuperfolioCore.Areas.Writer.Models
{
    public class AppUserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Resim Url bilgilerini girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail girin")]
        public string Mail { get; set; }
    }
}
