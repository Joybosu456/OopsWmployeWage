using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsEmployeeWage
{
    public class TillEndWage
    {
        /// <summary>
        ///UC-6 The par month.....
        /// </summary>
        public const int PART_TIME_EMP = 1;

        public const int FULL_TIME_EMP = 2;

        public const int EMP_RATE_PER_HOUR = 20;

        public const int NUM_OF_WORKING_DAY = 20;

        public const int MAX_HOUR = 100;
        public void EmpPerMonth()
        {




            int Emphrs = 0;



            int TotalHr = 0;

            int TotalSalary = 0;
            int WorokingDays = 0;


            while (TotalHr < MAX_HOUR || WorokingDays < NUM_OF_WORKING_DAY)
            {
                WorokingDays++;




                Random random = new Random();
                int num = random.Next(3);

                switch (num)
                {
                    case 1:
                        Emphrs = 4;
                        break;

                    case 2:
                        Emphrs = 8;
                        break;

                    default:
                        Emphrs = 0;
                        break;

                }
                TotalHr = (TotalHr + Emphrs);

                Console.WriteLine("Total hours" + TotalHr);

            }
            TotalSalary = (TotalHr * EMP_RATE_PER_HOUR);

            Console.WriteLine("Total Salary " + TotalSalary);


        }
    }
}