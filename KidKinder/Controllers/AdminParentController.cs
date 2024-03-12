using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class AdminParentController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ParentList()
        {
            var value = context.Parents.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateParent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateParent(Parent p)
        {
            context.Parents.Add(p);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
        public ActionResult DeleteParent (int id)
        {
            var value = context.Parents.Find(id);
            context.Parents.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
        [HttpGet]
        public ActionResult UpdateParent(int id)
        {
            var value = context.Parents.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateParent(Parent p)
        {
            var value = context.Parents.Find(p.ParentId);
            value.Address = p.Address;
            value.NameSurname = p.NameSurname;
            value.Phone = p.Phone;
            context.SaveChanges();
            return RedirectToAction("ParentList");
        }
    }
}