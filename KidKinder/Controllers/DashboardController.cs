using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            //Brans resim cizme olan ogrretmen sayisi
            ViewBag.ResimCizmeCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Resim").Select(y => y.BranchId).FirstOrDefault()).Count();
            //siniflarin ort ucret
            ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");
            ViewBag.Testimonial = context.Testimonials.Count().ToString();
            ViewBag.Contact = context.Contacts.Count().ToString();
            ViewBag.Security = context.Staffs.Where(x => x.StaffId == context.StaffBranches.Where(z => z.StaffBranchName == "Güvenlik Görevlisi").Select(y => y.StaffBranchId).FirstOrDefault()).Count();
            ViewBag.Cooker = context.Staffs.Where(x => x.Department == context.StaffBranches.Where(z => z.StaffBranchName == "Aşçı").Select(y => y.StaffBranchName).FirstOrDefault()).Count();
            ViewBag.Driver = context.Staffs.Where(x => x.Department == context.StaffBranches.Where(z => z.StaffBranchName == "Servis Şoförü").Select(y => y.StaffBranchName).FirstOrDefault()).Count();
            ViewBag.Janitor = context.Staffs.Where(x => x.Department == context.StaffBranches.Where(z => z.StaffBranchName == "Temizlik Görevlisi").Select(y => y.StaffBranchName).FirstOrDefault()).Count();
            ViewBag.Teacher = context.Teachers.Count().ToString();
            ViewBag.Student = context.Students.Count().ToString();
            var value = context.ClassRooms.OrderByDescending(x=>x.ClassRoomId).Take(4).ToList();
            ViewBag.ClassRoom = context.ClassRooms.Count().ToString();
            ViewBag.Parent = context.Parents.Count().ToString();
            ViewBag.Staff = context.Staffs.Count().ToString();
            ViewBag.MaxPriceClass = context.ClassRooms.Max(x => x.Price).ToString();
            ViewBag.MaxPriceClassName = context.ClassRooms.Max(x => x.Title).ToString();
            ViewBag.MinPriceClassName = context.ClassRooms.Min(x => x.Title).ToString();
            ViewBag.MinPriceClass = context.ClassRooms.Min(x => x.Price).ToString();
            ViewBag.CrowdedClass = context.ClassRooms.Max(x => x.TotalSeat).ToString();
            ViewBag.EmptyClass = context.ClassRooms.Min(x => x.TotalSeat).ToString();
            return View(value);
        }
       
    }
}