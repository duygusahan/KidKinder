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
    public class ClassRoomsController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var value = context.ClassRooms.ToList();
            return View(value);
        }
        public PartialViewResult ClassRoomsHeaderPartial()
        {
            return PartialView();
        }
    }
}