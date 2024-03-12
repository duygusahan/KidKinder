using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using System.Web.Security;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (result!=null)
            {
                FormsAuthentication.SetAuthCookie(admin.Username, true);
                Session["Username"] = result.Username.ToString();
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
            
            
        }
    }
}