using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Employeewage
    {
        public string Company;
        public int EMP_RATE_PER_HR, NUM_OF_WORKING_DAYS, NUM_OF_WORKING_HRS;
        public Employeewage(string Company, int EMP_RATE_PER_HR, int NUM_OF_WORKING_DAYS, int NUM_OF_WORKING_HRS)
        {
            this.Company=Company;
            this.EMP_RATE_PER_HR=EMP_RATE_PER_HR;
            this.NUM_OF_WORKING_DAYS=NUM_OF_WORKING_DAYS;
            this.NUM_OF_WORKING_HRS=NUM_OF_WORKING_HRS;
        }

        public void ComputeEmpWage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empHrs = 0; int empWage = 0; int totalEmpWage = 0; int day = 1; int totalHrs = 0;


            while (day <= NUM_OF_WORKING_DAYS && totalHrs <= NUM_OF_WORKING_HRS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3); //0 or 1 or 2

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
                day++;
                totalHrs += empHrs;

            }
            Console.WriteLine("\nComapany Name: {0}", Company);
            Console.WriteLine("Total Employee Wage is: " + totalEmpWage);
        }
    }
}
