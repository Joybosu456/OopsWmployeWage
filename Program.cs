using System;

namespace EmployWageMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            CompaneyWage EmployWageobj = new CompaneyWage();
            EmployWageobj.CalEmpWage();
            Console.WriteLine(EmployWageobj.Companey);
            Console.WriteLine(EmployWageobj.Companey_Name);
            Console.WriteLine(EmployWageobj.Companey_Two);
        }
    }
}