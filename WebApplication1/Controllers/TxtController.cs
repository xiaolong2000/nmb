using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TxtController : Controller
    {
        // GET: Txt
        public ActionResult GetView()
        {
            //Employee emp = new Employee();
            //emp.Name = "威廉. 莎士比亚";
            //ViewBag.empKey = emp;
            //return View(emp);

            Customer emm = new Models.Customer();
            Employee emp = new Models.Employee();
            emm.CustomerName = "张三";
            emm.Address = "打手";
            ViewData["Employee"] = emp;
            ViewBag.Customer = emm;

            emp.Name = "李四";
            emp.Salary = 2000;
            ViewData["Customer"] = emm;
            ViewBag.Employee = emp;
            return View("Index", emp);

        }

    }
}