using NTierMvc.BLL;
using NTierMvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierMvc.Controllers
{
    public class HomeController : Controller
    {
        protected IEmployee Employee { get; set; }

        public HomeController(IEmployee employee)
        {
            Employee = employee;
        }
        public ActionResult Index()
        {
         //   EmployeeInfo model = new EmployeeInfo();
            var res = Employee.GetEmployee();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}