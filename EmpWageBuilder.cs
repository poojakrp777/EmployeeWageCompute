using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public string Company;
        public int EMP_RATE_PER_HR, NUM_OF_WORKING_DAYS, NUM_OF_WORKING_HRS, totalEmpWage;

        public EmpWageBuilder(string Company, int EMP_RATE_PER_HR, int NUM_OF_WORKING_DAYS, int NUM_OF_WORKING_HRS)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HR = EMP_RATE_PER_HR;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.NUM_OF_WORKING_HRS = NUM_OF_WORKING_HRS;
        }
        public void setTotalEmpwage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total employee wage for company:" + this.Company + " is " + this.totalEmpWage;
        }
    }
}
