using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder  
    {

        public const int IS_PART_TIME_PRESENT = 1;
        public const int IS_FULL_DAY_PRESENT = 2;
        private int numOfCompany = 0;
        int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;

         ArrayList CompanyEmpWageList = new ArrayList();

        
        public EmpWageBuilder()
        {
            Console.WriteLine("Enter the Company name \n wagePerHr \n workingDaysPerMonth \n maxHoursPerMonth ");
            EmpWageObjectcs obj1 = new EmpWageObjectcs()
            {
                company = Console.ReadLine(),
                wagePerHr = Convert.ToInt32(Console.ReadLine()),
                workingDaysPerMonth = Convert.ToInt32(Console.ReadLine()),
                maxHoursPerMonth = Convert.ToInt32(Console.ReadLine()),
                TotalEmpWage = 0,
                day = 0


            };
            Console.WriteLine("Enter the Company name \n wagePerHr \n workingDaysPerMonth \n maxHoursPerMonth ");
            EmpWageObjectcs obj2 = new EmpWageObjectcs()
            {
                company = Console.ReadLine(),
                wagePerHr = Convert.ToInt32(Console.ReadLine()),
                workingDaysPerMonth = Convert.ToInt32(Console.ReadLine()),
                maxHoursPerMonth = Convert.ToInt32(Console.ReadLine()),
                TotalEmpWage = 0,
                day = 0

            };
            CompanyEmpWageList.Add(obj1);
            CompanyEmpWageList.Add(obj2);




        }
       
        public void ComputeEmpWage()
        {
            foreach (EmpWageObjectcs empWageObjectcs in this.CompanyEmpWageList)
            {
                this.ComputeEmpWage(empWageObjectcs);
                empWageObjectcs.TotalEmpWage = this.totalEmpSalary;
                Console.WriteLine("Total Salary of a employee " +empWageObjectcs.TotalEmpWage);

            }
        }
        private void ComputeEmpWage(EmpWageObjectcs empWageObjects)
        {
            
            while (day <= empWageObjects.workingDaysPerMonth && empHrs < empWageObjects.maxHoursPerMonth)
            {
                //day++;
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
                day++;
                totalEmpHrs += empHrs;
                Console.WriteLine( "Company Name : "+empWageObjects.company +" " +"Day#:"+day +"Emp Hrs : " + empHrs);
            }
            totalEmpSalary = totalEmpHrs * empWageObjects.wagePerHr;
            Console.WriteLine("TotalEmpWage : " +totalEmpSalary);

        }
    }
}

