using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DbModels
{
    public class TemporaryEmployee:Employees
    {
        public int NoOfHours { get; set; }
        public int HourlyPaid { get; set; }
    }
}
