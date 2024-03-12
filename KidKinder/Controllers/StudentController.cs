using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class StudentController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult StudentList()
        {
            var value = context.Students.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student s)
        {
            context.Students.Add(s);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
        public ActionResult DeleteStudent(int id)
        {
            var value = context.Students.Find(id);
            context.Students.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var value = context.Students.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student s)
        {
            var value = context.Students.Find(s.StudentId);
            value.NameSurname = s.NameSurname;
            value.ImageUrl = s.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("StudentList");
        }
    }
}