using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class ChartController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            ViewBag.ResimCizmeCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Resim").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.IngilizceCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "İngilizce ").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.SporCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Spor").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.AlmancaCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Almanca").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.BilimCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Temel Bilimler").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.DramaCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Drama").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.JimnastikCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Jimnastik").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.RobatikCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Robatik Kodlama").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.SatrancCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Satranç").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.SanatCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Sanat").Select(y => y.BranchId).FirstOrDefault()).Count();
            ViewBag.BaleCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Bale").Select(y => y.BranchId).FirstOrDefault()).Count();
            return View();
        }
    }
}