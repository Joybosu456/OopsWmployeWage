using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWageMulti
{
    public class MultipleCompanyWage
    {
        public string Companey = "TCS";
        public void CalEmpWage()
        {
            int IS_FULL_TIME = 2;
            int IS_PAR_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;


            int empHour = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else if (empCheck == IS_PAR_TIME)
            {
                empHour = 4;

            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is :" + empWage);
        }
    }
    public class EmployWage: MultipleCompanyWage
    {
        public string Companey_Name = "BGS";
    }
    public class CompaneyWage: EmployWage
    {
        public string Companey_Two = "GS LTD";
    }
}