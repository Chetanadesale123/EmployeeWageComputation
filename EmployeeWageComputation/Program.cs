using System;
namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addCompanyEmpWage("Infosys", 20, 2, 10);
        empWageBuilder.addCompanyEmpWage("Wipro", 10, 4, 20);
        empWageBuilder.ComputeEmpWage();

    }
}