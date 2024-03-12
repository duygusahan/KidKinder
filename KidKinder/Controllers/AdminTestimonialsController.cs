using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class AdminTestimonialsController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult TestimonialsList()
        {
            var value = context.Testimonials.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateTestimonials()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonials(Testimonial t)
        {
            context.Testimonials.Add(t);
            context.SaveChanges();
            return RedirectToAction("TestimonialsList");
        }
        public ActionResult DeleteTestimonials(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialsList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonials(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonials(Testimonial t)
        {
            var value = context.Testimonials.Find(t.TestimonialId);
            value.Comment = t.Comment;
            value.ImageUrl = t.ImageUrl;
            value.NameSurname = t.NameSurname;
            value.Title = t.Title;
            context.SaveChanges();
            return RedirectToAction("TestimonialsList");
        }
    }
}