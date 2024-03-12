using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;
namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Contact c)
        {
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            context.Contacts.Add(c);
            context.SaveChanges();
            return RedirectToAction("Index" , "Default");
        }
        public PartialViewResult ContactPartialHead()
        {
            return PartialView();
        }

        public PartialViewResult ContactAddressPartial()
        {
            ViewBag.desciription = context.Communications.Select(m => m.Description).FirstOrDefault();
            ViewBag.address = context.Communications.Select(m => m.Address).FirstOrDefault();
            ViewBag.email = context.Communications.Select(m => m.Email).FirstOrDefault();
            ViewBag.phone = context.Communications.Select(m => m.Phone).FirstOrDefault();
            return PartialView();
        }
    }
}