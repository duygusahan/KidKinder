using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class TeachersController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var value = context.Teachers.ToList();
            return View(value);
        }
        public PartialViewResult TaecherHeaderPartial()
        {
            return PartialView();
        }
    }
}