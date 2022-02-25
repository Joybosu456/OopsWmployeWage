using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsEmployeeWage
{
    public class PartTimeEmpWage
    {
        /// <summary>
        ///UC-2 Calculates the wage.
        /// </summary>

        public void CalculateWage()
        {
            int WorkPerHour = 20;
            int FullWorkingDay = 8;
            int CalculateWage = 0;

            Random random = new Random();
            int number = random.Next(2);

            if (number == 1)
            {
                CalculateWage = WorkPerHour * FullWorkingDay;

                Console.WriteLine("Calculate Wage = :" + CalculateWage);
            }
            else
            {
                CalculateWage = 0;
                Console.WriteLine("Calculate Wage =  :" + CalculateWage);
            }
        }
    }
}