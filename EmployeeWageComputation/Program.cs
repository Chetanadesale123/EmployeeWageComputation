using System;
namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        EmployeeWage infosys = new EmployeeWage("Infosys", 20, 25, 100);
        EmployeeWage wipro = new EmployeeWage("Wipro", 15, 20, 85);
        infosys.CalculateEmpWage();
        wipro.CalculateEmpWage();
    }
}