using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext(); // esetablishes connection to DB (see EmployeeContext.cs file -> Models folder)
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeID == id);

            return View(employee);
        }

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList();

            return View(employees);
        }
    }
}