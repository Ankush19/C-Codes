using LocalizationDemo.Helper;
using LocalizationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalizationDemo.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View(new UserDetails());
        }


        public ActionResult ChangeCurrentCulture(int id)
        {
            CultureHelper.CurrentCulture = id;
            Session["CurrentCulture"] = id;
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}