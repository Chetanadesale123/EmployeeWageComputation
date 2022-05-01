using System;
namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.ComputeEmpWage();


    }
}