using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SuperfolioCore.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/{controller}/{action}/{id?}")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
    
        public async Task<IActionResult> RecieverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListRecieverMessage(p);           

            return View(messageList);
        }
       
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(p);

            return View(messageList);
        }

        
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }
       
        public IActionResult RevieverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }

        [HttpGet]
    
        public IActionResult SendMessage()
        { 
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name= values.Name+ " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context context = new();
            var usernamesurname = context.Users.Where(x=>x.Email==p.Receiver).Select(y=>y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageManager.Tadd(p);

            return RedirectToAction("SenderMessage");
        }
        
    }
}
