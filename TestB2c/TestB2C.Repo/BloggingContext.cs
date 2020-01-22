using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Models.DbModels;

namespace TestB2C.Repo
{
    public class BloggingContext : DbContext
    {
        public DbSet<PermanentEmployee> PermanentEmployees { get; set; }
        public DbSet<PermanentEmployee> TemporaryEmployees { get; set; }
        public BloggingContext()
        { }

        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = ConfigurationManager.ConnectionStrings["EmployeeDb"].ToString();
            optionsBuilder.UseSqlServer(connstr);
        }

    }
}
