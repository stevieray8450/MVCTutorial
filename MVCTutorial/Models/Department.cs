﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTutorial.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<Employee> Employees { get; set; }
    }
}