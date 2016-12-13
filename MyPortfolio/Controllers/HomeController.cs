using MyPortfolio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SetLang(int id)
        {
            LanguageSwitch.SetLang((Lang)id);
            return RedirectToAction(Request.UrlReferrer.AbsoluteUri);
        }
    }
}