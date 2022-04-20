using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1, IS_ABSENT = 0, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULL_DAY_PRESENT = 1, IS_PART_TIME_PRESENT = 2;
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
        public void CalculateEmpWage(string company, int wagePerHr, int workingDaysPerMonth, int maxHoursPerMonth)
        {
            for (int i = 0; i < workingDaysPerMonth && empHrs < maxHoursPerMonth; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_ABSENT:
                        empHrs += 0;
                        break;
                    case IS_FULL_DAY_PRESENT:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PART_TIME_PRESENT:
                        empHrs += FULL_DAY_HR;
                        break;
                }
            }
            totalEmpWage = empHrs * wagePerHr;
            Console.WriteLine("Total Emp Wage for company :" +company +" is : " + totalEmpWage);
        }
    }
}
