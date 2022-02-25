using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsEmployeeWage
{
    public class OopsSwitchCase
    {

        /// <summary>
        ///UC-4 Check the employ using switch case.
        /// </summary>

        public void CheckEmployUsingSwitchCase()
        {
            int IS_FULL_TIME = 2;

            int IS_PER_TIME = 1;

            int IS_EMP_RATE_PER_HOUR = 20;

            int EmpHour = 0;
            int EmpWage = 0;
            //Random random = new Random();
            //int num = random.Next(3);

            //Console.WriteLine("Enter your Case Number :-");
            //int Number = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int Number = random.Next(3);

            switch (Number)
            {
                case 1:
                    EmpHour = 8;

                    break;

                case 2:

                    EmpHour = 4;

                    break;

                default:

                    EmpHour = 0;

                    break;
            }
            EmpWage = EmpHour * IS_EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee  :" + EmpWage);

        }


    }
}