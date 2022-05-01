using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder : IComputeEmpWage
    {

        public const int IS_PART_TIME_PRESENT = 1;
        public const int IS_FULL_DAY_PRESENT = 2;
        private int numOfCompany = 0;
        private EmployeeWage[] employeeWageArray;
        public EmpWageBuilder()
        {
            this.employeeWageArray = new EmployeeWage[5];

        }
        public void addCompanyEmpWage(string company, int wagePerHr, int workingDaysPerMonth, int maxHoursPerMonth)
        {
            employeeWageArray[this.numOfCompany] = new EmployeeWage(company, wagePerHr, workingDaysPerMonth, maxHoursPerMonth);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                employeeWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.employeeWageArray[i]));
                Console.WriteLine(this.employeeWageArray[i].ToString());

            }
        }
        private int ComputeEmpWage(EmployeeWage employeeWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= employeeWage.maxHoursPerMonth && totalWorkingDays < employeeWage.workingDaysPerMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_DAY_PRESENT:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME_PRESENT:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * employeeWage.wagePerHr;

        }
    }
}

