using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialClassRooms()
        {
            var values = context.ClassRooms.Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBookASeat()
        {
            return PartialView();
        }

        public PartialViewResult PartialTeachers()
        {
            var values = context.Teachers.OrderByDescending(x=>x.TeacherId).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonials()
        {
            var values = context.Testimonials.Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {

            return PartialView();
        }
    }
}