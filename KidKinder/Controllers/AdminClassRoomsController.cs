using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;


namespace KidKinder.Controllers
{
    public class AdminClassRoomsController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ClassRoomsList()
        {
            var value = context.ClassRooms.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateClassRooms()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateClassRooms(ClassRoom cls)
        {
            context.ClassRooms.Add(cls);
            context.SaveChanges();
            return RedirectToAction("ClassRoomsList");
        }
        public ActionResult DeleteClassRooms(int id)
        {
            var value = context.ClassRooms.Find(id);
            context.ClassRooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ClassRoomsList");
        }
        [HttpGet]
        public ActionResult UpdateClassRooms(int id)
        {
            var value = context.ClassRooms.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateClassRooms(ClassRoom c)
        {
            var value = context.ClassRooms.Find(c.ClassRoomId);
            value.AgeofKids = c.AgeofKids;
            value.ClassTime = c.ClassTime;
            value.Description = c.Description;
            value.ImageUrl = c.ImageUrl;
            value.Price = c.Price;
            value.Title = c.Title;
            value.TotalSeat = c.TotalSeat;
            context.SaveChanges();
            return RedirectToAction("ClassRoomsList");
        }
    }
}