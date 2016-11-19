
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace goswamibhatttailang.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            TempData["Value"] = "avi goswami";//way of using temp data ;declaration .
         
            return View();
        }
        public class KritiJi
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; } 
        }
        public ActionResult EmployeeList()
        {
            string SecondName = (string)TempData["Value"];// assigning temp data with datatype related.
            ViewBag.Names = SecondName;
            ViewBag.Name = "kriti tailang";
            KritiJi obj = new KritiJi();
            obj.FirstName = "Kriti";
            obj.LastName = "Tailang";
            obj.PhoneNumber = "9999999999";
            obj.Email = "kriti@gmail.com";
            ViewBag.Kriticlass = obj;
            KritiJi ob1 = new KritiJi();
            ob1.FirstName = "ABC"; 
            ob1.LastName = "XYZ";
            ob1.Email = "abc@gmail.com";
            ob1.PhoneNumber = "987456123";
            KritiJi ob2 = new KritiJi();
            ob2.FirstName = "ABC";
            ob2.LastName = "XYZ";
            ob2.Email = "abc@gmail.com";
            ob2.PhoneNumber = "987456123";
            KritiJi ob3 = new KritiJi();
            ob3.FirstName = "ABC";
            ob3.LastName = "XYZ";
            ob3.Email = "abc@gmail.com";
            ob3.PhoneNumber = "987456123";
            List<KritiJi> lst = new List<KritiJi>();
            lst.Add(obj);
            lst.Add(ob1);
            lst.Add(ob2);
            lst.Add(ob3);
            ViewBag.Kriticlass = lst;
             return View();
        }
    }
}