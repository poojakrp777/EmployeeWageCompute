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
            Employeewage empWage = new Employeewage();
            empWage.addCompanyEmpWage("dmart", 20, 30, 120);
            empWage.addCompanyEmpWage("relaince", 50, 80, 100);
            empWage.addCompanyEmpWage("Deloitte", 65, 84, 67);

            empWage.CalculateEmpWage();


            Console.ReadLine();
        }
    }
}
