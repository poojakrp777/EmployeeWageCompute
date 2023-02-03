using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Employeewage
    {
        private int numOfCompany = 0;
        private EmpWageBuilder[] companyEmpWageArray;


        public Employeewage()
        {
            this.companyEmpWageArray = new EmpWageBuilder[5];
        }

        
        public void addCompanyEmpWage(string Company, int EMP_RATE_PER_HR, int NUM_OF_WORKING_DAYS, int NUM_OF_WORKING_HRS)
        {
            companyEmpWageArray[this.numOfCompany] = new EmpWageBuilder(Company, EMP_RATE_PER_HR, NUM_OF_WORKING_DAYS, NUM_OF_WORKING_HRS);
            numOfCompany++;
        }
        public void CalculateEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpwage(this.CalculateEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int CalculateEmpWage(EmpWageBuilder companyEmpWage)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empHrs = 0; int empWage = 0; int totalEmpWage = 0; int day = 1; int totalHrs = 0;


            while (day <= companyEmpWage.NUM_OF_WORKING_DAYS && totalHrs <= companyEmpWage.NUM_OF_WORKING_HRS)
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
                empWage = empHrs * companyEmpWage.EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                day++;
                totalHrs += empHrs;

            }
            return totalEmpWage;
        }
    }
}
