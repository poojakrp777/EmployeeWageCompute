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
            int Part_Time = 2;
            const int EmpWagePerHr = 20;
            int empHrs = 0, empWage = 0;

            //UC-1 Check employee present or not
            Random random = new Random();
            int EmpCheck = random.Next(0, 3); //the range will take 0,1,2

            if (EmpCheck == Is_Present)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }

            //UC3 Calculating Emp Part time wage
            else if (EmpCheck == Part_Time)
            {
                Console.WriteLine("Employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                // empHrs = 0; if emp is absent it's automatically take 0

            }

            //UC-2 calculate Employee daily Wage
            empWage = EmpWagePerHr * empHrs;
            Console.WriteLine("Employee Wage is:" + empWage);
            Console.ReadLine();
        }
    }
}
