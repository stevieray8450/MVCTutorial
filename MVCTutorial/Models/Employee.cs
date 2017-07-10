using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTutorial.Controllers;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTutorial.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int EmployeeID {get; set;}
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }
    }
}