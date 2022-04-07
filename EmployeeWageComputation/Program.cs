using System;
namespace EmployeeWageComputation;
class Program
{
    static void Main(string[] args)
    {

        EmployeeWage computation = new EmployeeWage();
        computation.EmployeeAttendence();
        computation.CalculateEmpWage();
    }
}