using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Gender { get; set; }
        string City { get; set; }
        int DepartmentId { get; set; }
        DateTime? DateOfBirth { get; set; }
    }
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
    }
}
