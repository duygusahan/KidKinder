using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class AdminGalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult GalleryList()
        {
            var value = context.Galleries.ToList();
            return View(value);
        }
        public ActionResult ImageStatusUpdate(int id)
        {
            var value = context.Galleries.Find(id);
            value.Status = !value.Status; 
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        public ActionResult DeleteGallery(int id)
        {
            var value = context.Galleries.Find(id);
            context.Galleries.Remove(value);
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }

        [HttpGet]
        public ActionResult CreateGallery(int id)
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateGallery(Gallery g)
        {
            context.Galleries.Add(g);
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
    }
}