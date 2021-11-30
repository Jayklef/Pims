using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pims.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
