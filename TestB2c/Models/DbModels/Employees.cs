using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DbModels
{
    public abstract class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
