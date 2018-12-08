using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GoudaiController : Controller
    {
        // GET: Goudai
        public ActionResult GetControl()
        {

            Employee emp = new Employee();

            emp.Name = "大号";
            ViewBag.empKey = emp;
            return View( emp);

        }
        


    }
}