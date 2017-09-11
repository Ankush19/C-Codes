using AjaxApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxApplication.Controllers
{
    public class UserController : Controller
    {
        static List<Users> userlist = new List<Users>();
        
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Register(UserBinder userBinder)
        {
            //userlist.Add(userBinder.User);
            using (var entry=new UserContext())
            {
                entry.UserEntries.Add(userBinder.User);
                entry.SaveChanges();

                userlist = entry.UserEntries.ToList();
                
            }
                return View("Insert", userBinder);
        }

        public ActionResult GetAllUsers()
        {
            

            return Json(userlist,JsonRequestBehavior.AllowGet); 
        }

        public ActionResult Search(int id)
        {
            var flag = false;
            string searchentry = null;
            using (var entry = new UserContext())
            {
                foreach (var item in entry.UserEntries.Where((i)=>i.MyID.Equals(id)))
                {
                    flag = true;
                    searchentry = item.Name;
                }
            }
            if (flag)
            {
                return Json(searchentry, JsonRequestBehavior.AllowGet);
            }

            return View();
        }
    }
}