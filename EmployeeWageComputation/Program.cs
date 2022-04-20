using System;
namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {
        EmployeeWage computation = new EmployeeWage();
        computation.EmployeeAttendence();
        computation.CalculateEmpWage("Infosys", 20, 25, 100);
        computation.CalculateEmpWage("Wipro", 15, 20, 85);
    }
}