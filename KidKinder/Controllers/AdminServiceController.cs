using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;


namespace KidKinder.Controllers
{
    public class AdminServiceController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ServicesList()
        {
            var value = context.Services.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service p )
        {
            context.Services.Add(p);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        public ActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service p)
        {
            var value = context.Services.Find(p.ServiceId);
            value.Title = p.Title;
            value.Desciription = p.Desciription;
            value.IconUrl = p.IconUrl;
            context.SaveChanges();
            return RedirectToAction("ServicesList");
        }
    }
}