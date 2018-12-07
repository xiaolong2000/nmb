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
    }
}