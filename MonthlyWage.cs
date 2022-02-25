using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsEmployeeWage
{
    internal class MonthlyWage
    {

        public void OopsMonthlyWage()
        {
            int IS_FULL_TIME_EMP = 1;
            int IS_PART_TIM_EMP = 0;
            int EMP_RATE_PER_HOUR = 20;
            int WORK_DAY_PER_MONTH = 20;

            int EmpHour = 0;
            int MonWage = 0;

            int PerMoonthWage = 0;
            int PerDayWage = 0;


            Random random = new Random();
            int EmpCheck = random.Next(2);

            if (EmpCheck == IS_FULL_TIME_EMP)
            {
                EmpHour = 8;
                PerDayWage = EmpHour * EMP_RATE_PER_HOUR;

                PerMoonthWage = PerDayWage * WORK_DAY_PER_MONTH;

                Console.WriteLine("Full time employee wage per month:=" + PerMoonthWage);

            }
            else
            {
                EmpHour = 4;
                PerDayWage = EmpHour * EMP_RATE_PER_HOUR;

                PerMoonthWage = PerDayWage * WORK_DAY_PER_MONTH;

                Console.WriteLine("Part time employee wage per month:=" + PerMoonthWage);
            }
        }
    }
}