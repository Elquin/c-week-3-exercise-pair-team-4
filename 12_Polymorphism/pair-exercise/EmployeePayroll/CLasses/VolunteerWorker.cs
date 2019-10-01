using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class VolunteerWorker : IWorker
    {
        public VolunteerWorker(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public double CalculateWeeklyPay(int hoursWorked)
        {
            return hoursWorked * 0;
        }
    }
}
