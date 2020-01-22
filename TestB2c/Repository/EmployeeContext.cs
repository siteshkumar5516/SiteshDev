using System.Collections.Generic;
using System.Configuration;
using Common;
using Microsoft.EntityFrameworkCore;
using Models.DbModels;
namespace Repository
{
    public class EmployeeContext: DbContext
    {
        public DbSet<PermanentEmployee> PermanentEmployees { get; set; }
        public DbSet<TemporaryEmployee> TemporaryEmployees { get; set; }
        public DbSet<EmployStatus> EmployeesStatus { get; set; }
        public EmployeeContext()
        { }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        { }
      
    }
}
