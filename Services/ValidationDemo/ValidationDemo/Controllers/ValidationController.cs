using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DoRegister()
        {
            return View("ValidView");

        }
        public ActionResult Register(Register m)
        {
            
            if (!ModelState.IsValid)
            {
                return View("ValidView", m);

            }
            else
                using (var entry = new RegisterContext())

                {
                    entry.Entries.Add(m);
                    entry.SaveChanges();
                    Console.WriteLine("Entry added");
                }

            return View("Login");
          
        }

        public ActionResult Login(Login l)
        {
            //var user = l.UserName;
            var flag=false;
            using (var user =new RegisterContext())
            {
                foreach (var item in user.Entries.Where((i)=>i.UserName.Equals(l.UserName)&&i.Password.Equals(l.Password)))
                {
                    flag = true;
                }
                
            }
            if (flag)
            {
                return View("LoginSuccessful",l);
            }
            return View("Login",l);
        }
    }
}