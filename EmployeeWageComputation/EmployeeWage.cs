using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 0, Wage_PER_HR = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULL_DAY_PRESENT = 0, IS_PART_TIME_PRESENT = 1;
        int empHrs, totalEmpWage;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");

        }
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == IS_FULL_DAY_PRESENT)
            {
                empHrs = FULL_DAY_HR;
            }
            else if(check == IS_PART_TIME_PRESENT)
            {
                empHrs = PART_DAY_HR;
            }
            else
            {
                empHrs = 0;
            }
            totalEmpWage = empHrs * Wage_PER_HR;
            Console.WriteLine("Total Emp Wage for a day" + totalEmpWage);


        }
        
            


            

    }
}
