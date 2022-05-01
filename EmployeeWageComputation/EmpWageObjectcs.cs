using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageObjectcs
    {
        public string company { get; set; } 
        public int wagePerHr { get; set; } 
        public int workingDaysPerMonth { get; set; }
        public int maxHoursPerMonth { get; set; }
        public int TotalEmpWage { get; set; }
        public int day { get; set; }    
    }
}
