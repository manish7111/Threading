using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace EmployeePayrollUsingThreads
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Employee Payroll using Threads");
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            employeePayrollOperations.AddEmployeeDetails();
            employeePayrollOperations.AddEmployeeDetailsUsingThreads();
            int result=employeePayrollOperations.EmployeeCount();
            Console.WriteLine(result);
            //employeePayrollOperations.UpdateEmployee();
        }
    }
}
