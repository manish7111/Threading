using EmployeePayrollUsingThreads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Threading
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddedMultipleEmployeeAndGetCount()
        {
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            employeePayrollOperations.AddEmployeeDetails();
            employeePayrollOperations.AddEmployeeDetailsUsingThreads();
            int result = employeePayrollOperations.EmployeeCount();
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void UpdateSalaryToMultipleEmployees()
        {
            Stopwatch stopwatch = new Stopwatch();
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            employeePayrollOperations.AddEmployeeDetails();
            stopwatch.Start();
            var result=employeePayrollOperations.UpdateEmployee(1);
            employeePayrollOperations.AddEmployeeDetailsUsingThreads();
            Assert.AreEqual(2000, result.BasicPay);
        }
    }
}
