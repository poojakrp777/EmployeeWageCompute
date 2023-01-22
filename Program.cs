﻿using System;
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
        static void Main(string[] args)
        { 
            int empHrs = 0;int empWage = 0;int totalEmpWage = 0;int day = 1;
            Console.WriteLine("Welcome to EmployeeWage computation");
            //UC5-20days Employee Wage calculation
            for (day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3); //0 or 1 or 2

                //UC4-Employee Wage calculation using switch case
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage is:" + empWage);
            }
            Console.WriteLine("Total Employee wage for {0} days:{1}", day, totalEmpWage);
            Console.ReadLine();
        }
    }
}
