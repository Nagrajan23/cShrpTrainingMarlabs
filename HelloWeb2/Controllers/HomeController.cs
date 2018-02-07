using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWeb2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["MyTimeSession"] = DateTime.Now.ToString();
            TempData["MyTimeTemp"] = DateTime.Now.ToString();
            ViewBag.MyTime = DateTime.Now.ToString();
            //return View();
            return RedirectToAction("GotoHome", "Home");
        }

        public ActionResult GotoHome()
        {
            //ViewData["MyTime"] = DateTime.Now.ToString();
            //ViewBag.MyTime = DateTime.Now.ToString();
            return View();
        }
    }
}