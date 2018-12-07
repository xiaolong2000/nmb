using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;



namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public string ada()
        {
            return "顶顶顶顶";
        }
        public Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerNmae = "asd";
            ct.Address = "adaa";
            return ct;

        }
        public ActionResult GetView()
        {
            // DateTime dt = DateTime.Now;
            // int hour = dt.Hour;
            // if(hour > 12)
            // {
            //     return View("MyView");
            // }
            // else
            // {
            //    return View("YourView");
            // }
            // Employee emp = new Employee();
            // emp.Name = "大号";
            //emp.Salary = 2300;
            //  ViewData["EmpKey"] = emp;
            //    return View("MyView");

            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "上午好";

            }
            else
            {
                greeting = "下午好";
            }
            ViewData["greeting"] = greeting;
            Employee emp = new Employee();
            emp.Name = "大号";
            emp.Salary = 2300;
              ViewData["EmpKey"] = emp;
                return View("MyView");


        }
    }
}