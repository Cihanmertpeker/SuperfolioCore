using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string UserImageUrl { get; set; }
        public bool UserStatus { get; set; }
        public List<AppUserMessage> AppUserMessages { get; set; }
    }
}
 