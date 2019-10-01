using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class SalaryWorker : IWorker
    {

        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            this.AnnualSalary = annualSalary;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public double AnnualSalary { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double CalculateWeeklyPay(int hoursWorked)
        {
            return AnnualSalary / 52;
        }
    }
}
