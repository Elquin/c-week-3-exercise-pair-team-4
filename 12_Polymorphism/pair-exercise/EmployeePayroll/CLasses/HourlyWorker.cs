using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class HourlyWorker : IWorker
    {
        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            this.HourlyRate = hourlyRate;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public double HourlyRate { get; }
        public string FirstName { get; }
        public string LastName { get; }
        
        public double CalculateWeeklyPay(int hoursWorked)
        {
            int overtime = hoursWorked - 40;
            if (hoursWorked <= 40)
            {
                return HourlyRate * hoursWorked;
            }
            else
            {
                return HourlyRate * hoursWorked + (HourlyRate * overtime * .5);
            }
        }
    }
}
