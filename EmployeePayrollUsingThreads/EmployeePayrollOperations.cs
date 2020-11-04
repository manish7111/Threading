using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace EmployeePayrollUsingThreads
{
    public class EmployeePayrollOperations
    {
        public EmployeeDetails[] employeeDetails;
        public void AddEmployeeDetails()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            this.employeeDetails = new EmployeeDetails[]
            {
                new EmployeeDetails(EmployeeID:1,EmployeeName:"Manish",PhoneNumber:"7760467611",Address:"xyz",Department:"HR",Gender:'M',BasicPay:100,Deductions:2,TaxablePay:20,Tax:100,NetPay:400,City:"Banglore",Country:"India"),
                new EmployeeDetails(EmployeeID:2,EmployeeName:"Reddy",PhoneNumber:"7760467611",Address:"xyz",Department:"HR",Gender:'M',BasicPay:100,Deductions:2,TaxablePay:20,Tax:100,NetPay:400,City:"Banglore",Country:"India")
            };
            //UC-5
            this.Display();
            //UC-6
            //this.UpdateEmployee(1);
            stopwatch.Stop();
           // this.Display();
            Console.WriteLine(stopwatch.Elapsed);
        }
        public void AddEmployeeDetailsUsingThreads()
        {
            Stopwatch stopwatch = new Stopwatch();
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            Thread thr = new Thread(new ThreadStart(employeePayrollOperations.AddEmployeeDetails));
            thr.Start();
        }
        public int EmployeeCount()
        {
            return this.employeeDetails.Length;
        }
        public void Display()
        {
            foreach (EmployeeDetails employee in this.employeeDetails)
            {
                Console.WriteLine(employee.EmployeeID + " " + employee.EmployeeName + " " + employee.PhoneNumber + " " + employee.Address + " " + employee.Department+" "+employee.BasicPay);
            }
        }
        public EmployeeDetails UpdateEmployee(int id)
        {
            foreach (EmployeeDetails employee in this.employeeDetails)
            {
                if (employee.EmployeeID==id)
                {
                    employee.BasicPay = 2000;
                    return employee;
                } 
            }
            this.Display();
            return null;
        }
    }
}
