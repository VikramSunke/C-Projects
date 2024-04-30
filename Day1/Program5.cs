
/* Class name: Program5.cs
* This program stores employee details, calculates the salary structure based on taxes and deductions, and prints the total salary.
 * */
using System.Numerics;

namespace Day1     //Project name: Day1
{
    internal class Program5  // Class name: Program5.cs 
    {
        static void Main(string[] args)
        {
            int employeeId;
            string name;
            string mobileNumber;
            char gender;
            double basicSalary, hra, dearnessAllowance,conveyanceAllowance, tax, pf, totalAllowances, totalDeductions, netSalary;

            Console.WriteLine("Enter employee Id: ");
            employeeId=Convert.ToInt32(Console.ReadLine()); // Converting string user input to the integer type

            Console.WriteLine("Enter employee name");
            name = Console.ReadLine();

            Console.WriteLine("Enter employee mobile number");
            mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter gender(M/F)");
            gender=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter all your salary details In INR");
            Console.WriteLine("Enter basic salary: ");
            basicSalary=Convert.ToDouble(Console.ReadLine()); // Converting string user input to the double type

            Console.WriteLine("Enter HRA:");
            hra=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter dearness allowance:");
            dearnessAllowance=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter conveyance allowance: ");
            conveyanceAllowance=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter tax:");
            tax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter PF:");
            pf = Convert.ToDouble(Console.ReadLine());

            /* Calculating net salary   netSalary = (basicSalary + hra + dearness allowance + conveyance allowance) - tax - pf;
             * HRA,dearness allowance, conveyance allowance
             * tax and  provided fund are the total deductions;
             */
            totalAllowances=hra+dearnessAllowance+conveyanceAllowance;
            totalDeductions = tax + pf;
            netSalary = basicSalary + totalAllowances - totalDeductions;
            Console.WriteLine("Total allowances: {0}",totalAllowances);
            Console.WriteLine("Total dedcutions:{0}", totalDeductions);
            Console.WriteLine("Total net Salary:{0}",netSalary);
            Console.ReadKey();

        }
    }
}
