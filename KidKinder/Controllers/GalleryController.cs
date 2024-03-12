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
    public class GalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Galleries.Where(g => g.Status == true).Take(6).ToList();
            return View();
        }
        public PartialViewResult GalleryHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult GalleryPartial()
        {
            return PartialView();
        }

    }
}