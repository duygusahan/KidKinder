using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class AdminStaffController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult StaffList()
        {
            var value = context.Staffs.ToList();
            return View(value);
        }
       [HttpGet]
       public ActionResult CreateStaff()
        {
            List<SelectListItem> values = (from x in context.StaffBranches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.StaffBranchName,
                                               Value = x.StaffBranchId.ToString()
                                           }
                                           ).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateStaff(Staff s)
        {
            context.Staffs.Add(s);
            context.SaveChanges();
            return RedirectToAction("StaffList");
        }
        public ActionResult DeleteStaff(int id)
        {
            var value = context.Staffs.Find(id);
            context.Staffs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("StaffList");
        }
        [HttpGet]
        public ActionResult UpdateStaff(int id)
        {
            List<SelectListItem> values = (from x in context.StaffBranches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.StaffBranchName,
                                               Value = x.StaffBranchId.ToString()

                                           }
                                           ).ToList();
            ViewBag.v = values;
            var value = context.Staffs.Find(id);
                return View();
        }
        [HttpPost]
        public ActionResult UpdateStaff(Staff s)
        {
            var value = context.Staffs.Find(s.StaffId);
            value.Department = s.Department;
            value.ImageUrl = s.ImageUrl;
            value.NameSurname = s.NameSurname;
            value.Price = s.Price;
            value.StaffBranch = s.StaffBranch;
            return RedirectToAction("StaffList");
        }
    }
}