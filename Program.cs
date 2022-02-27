using OpsEmployeeWage;
using System;

namespace EmployWageMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompaneyWage EmployWageobj = new CompaneyWage();
            //EmployWageobj.CalEmpWage();
            //Console.WriteLine(EmployWageobj.Companey);
            //Console.WriteLine(EmployWageobj.Companey_Name);
            //Console.WriteLine(EmployWageobj.Companey_Two);

            EmpWageBuldierProb obj = new EmpWageBuldierProb("Dmart",20,2,10);
            EmpWageBuldierProb relaince = new EmpWageBuldierProb("Relaince", 10, 4, 20);
            obj.computeEmpWage();
            Console.WriteLine(obj.toString());
            relaince.computeEmpWage();
            Console.WriteLine(relaince.toString());
        }
    }
}