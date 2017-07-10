using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVCTutorial.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }

        [HttpGet] //this method will only respond to an HTTP GET request.
        // when a user clicks the "Create" button, this method will not POST anything back to the server
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost] // this method will only respond to an HTTP POST request
        //// used for submitting the form data to the server
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Employee employee = new Employee();
        //    employee.Name = formCollection["Name"];
        //    employee.Gender = formCollection["Gender"];
        //    employee.City = formCollection["City"];
        //    employee.DepartmentId = Convert.ToInt32(formCollection["DepartmentId"]);
        //    employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employeeBusinessLayer.AddEmployee(employee);

        //    return RedirectToAction("Index");


        [HttpPost] // this method will only respond to an HTTP POST request
        // used for submitting the form data to the server
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Employee employee = new Employee();
            TryUpdateModel(employee);
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(emp => emp.Id == id);
            return View(employee);
        }

        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post(int id)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    Employee employee = employeeBusinessLayer.Employees.Single(x => x.Id == id);
        //    UpdateModel(employee, new string[] { "Id", "Gender", "City", "DepartmentId", "DateOfBirth" });

        //    if(ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.EditEmployee(employee);

        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post([Bind(Include = "Id, Gender, City, DepartmentId, DateOfBirth")]
        //                              Employee employee)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employee.Name = employeeBusinessLayer.Employees.Single(x => x.Id == employee.Id).Name;

        //    if (ModelState.IsValid)
        //    { 
        //        employeeBusinessLayer.EditEmployee(employee);

        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(x => x.Id == id);
            UpdateModel<IEmployee>(employee); // only the properties w/in the IEmployee interface will 
                                              // be updated

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.EditEmployee(employee);

                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(id);

            return RedirectToAction("Index"); 

        }
    }
}