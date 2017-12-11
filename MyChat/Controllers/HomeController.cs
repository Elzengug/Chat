using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MyChat.Models;
using MyChat.Models.ViewModels;

namespace MyChat.Controllers
{
    public class HomeController : Controller
    {
       
        private MyChatContext db = new MyChatContext();

        [HttpGet]
        public ActionResult Index()
        {
            MessageViewModel messageViwModel = new MessageViewModel
            {
                ChatMessage = db.Messages.Include(u => u.ApplicationUser)
            };

            return View(messageViwModel);
        }
        [HttpPost]
        public ActionResult Index(Message mes)
        {
            mes.ApplicationUserId = User.Identity.GetUserId();
            db.Messages.Add(mes);
            db.SaveChanges();
            MessageViewModel messageM = new MessageViewModel
            {
                ChatMessage = db.Messages
            };

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}