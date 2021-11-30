using Microsoft.EntityFrameworkCore;
using Pims.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pims.Data
{
    public class PimsContext : DbContext
    {
        public PimsContext(DbContextOptions<PimsContext> options): base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
