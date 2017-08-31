using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [ActionName("GetString")]
        public string GetString()
        {
            return "Hi!This is Ankush Dudani#Ankii";
        }

        public ActionResult GetData()
        {
            MyInfo info = new MyInfo();
            info.Name = "Ankush";
            info.MyId = 1;
            info.Age = 22;
            return View("MyView",info);

        }
    }
}