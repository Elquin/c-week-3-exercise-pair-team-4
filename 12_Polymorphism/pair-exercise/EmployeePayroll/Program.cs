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
            int totalHours = 0;
            double totalPay = 0.00;
            Random random = new Random();
            foreach (IWorker worker in workers)
            {
                int hoursWorked = random.Next(0, 120);
                totalHours += hoursWorked;
                totalPay += worker.CalculateWeeklyPay(hoursWorked);
                Console.WriteLine($"{worker.LastName}, {worker.FirstName} \t{hoursWorked}  \t {worker.CalculateWeeklyPay(hoursWorked):C}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total Hours: {totalHours}");
            Console.WriteLine($"Total Pay: {totalPay:C}");
            Console.ReadLine();
        }
    }
}
