using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUserMessage
    {
        [Key]
        public int MessageId { get; set; }
        public string MessageTitle { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
