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
    public class AdminContactController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ContactList()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
        public ActionResult GetContactDetails(int id)
        {
           
            var contactvalue = context.Contacts.FirstOrDefault(x => x.ContactId == id);

            if (contactvalue == null)
            {
                
                return RedirectToAction("Error");
            }

            return View(contactvalue);
        }
        public ActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult UpdateContext(int id)
        {
            var valuue = context.Contacts.Find(id);
            return View(valuue);
        }
        [HttpPost]
        public ActionResult UpdateContext(Contact c)
        {
            var value = context.Contacts.Find(c.ContactId);
            value.IsRead = c.IsRead;
            value.Email = c.Email;
            value.Message = c.Message;
            value.NameSurname = c.NameSurname;
            value.SendDate = c.SendDate;
            value.Subject = c.Subject;
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}