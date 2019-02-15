using AutoMapper;
using NTierMvc.BLL;
using NTierMvc.DAL;
using NTierMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierMvc.Controllers
{
    public class EmployeeController : Controller
    {
        protected IEmployee Employee { get; set; }

        public EmployeeController(IEmployee employee)
        {
            Employee = employee;
        }
        public ActionResult Index()
        {
            var employeeList = Employee.GetEmployee();

            return View(employeeList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeVm model)
        {
            var emp = GetEmp(model);
            Employee.AddEmployee(emp);

            return View();
        }

        private static Employee GetEmp(EmployeeVm model)
        {
            return Mapper.Map<EmployeeVm, Employee>(model);
        }

        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }

    }
}