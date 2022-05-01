using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int wagePerHr, int workingDaysPerMonth, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public  void GetTotalWageByCompany(String Company);
    }
    public class EmployeeWage
    {
        public string company;
        public int wagePerHr, workingDaysPerMonth, maxHoursPerMonth, totalEmpWage;
        public EmployeeWage(string company, int wagePerHr, int workingDaysPerMonth, int maxHoursPerMonth)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string ToString()
        {
            return "Total Emp wage for Company : " + this.company + " " + "is :" + this.totalEmpWage;

        }
    }
}
