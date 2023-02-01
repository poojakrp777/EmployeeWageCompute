using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int NUM_OF_WORKING_HRS = 80;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage computation");
            Console.WriteLine("Output of Total Employee wage for a Month  :");
            Employeewage emp = new Employeewage();
            emp.ComputeEmpWage("Reliance", 20, 25, 150);
            emp.ComputeEmpWage("D-Mart", 15, 20, 100);
            emp.ComputeEmpWage("More", 35, 18, 170);
            Console.ReadLine();
        }
    }
}
