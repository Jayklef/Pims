using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pims.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string StaffNumber { get; set; }
        public string GradeLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }
    }
}
