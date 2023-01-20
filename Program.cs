using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            int Is_Present = 1;
            const int EmpWagePerHr = 20;
            int empHrs = 0, empWage = 0;

            //UC-1 Check employee present or not
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (EmpCheck == Is_Present)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");

            }

            //UC-2 calculate EmployeeWage
            empWage = EmpWagePerHr * empHrs;
            Console.WriteLine("Employee Wage is:" + empWage);
            Console.ReadLine();
        }
    }
}
