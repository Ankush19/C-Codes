using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Helper;
using WebApplication4.Models;

namespace WebApplication4.Controllers
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