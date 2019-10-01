using System;
using System.Collections.Generic;
using System.Text;
using EmployeePayroll.CLasses;

namespace EmployeePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>();
            workers.Add(new SalaryWorker(50000.00, "Microsoft", "Paul"));
            workers.Add(new HourlyWorker(15, "Susan", "Elevator"));
            workers.Add(new VolunteerWorker("George (Goofy)", "Geef"));

            Console.WriteLine("Employee \t Hours Worked \t Pay");
            Console.WriteLine("====================================================");
            foreach (IWorker worker in workers)
            {
                Console.WriteLine($"{worker.LastName}, {worker.FirstName} \t 45 \t {worker.CalculateWeeklyPay(45):C}");
            }

            Console.ReadLine();
        }
    }
}
