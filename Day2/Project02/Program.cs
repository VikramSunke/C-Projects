using System;

namespace Project02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student Details & Marks for the below subjects");
            Console.Write("Student name: ");
            string studentName = Console.ReadLine();

            Console.Write("English (100): ");
            int english = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sanskrit (100): ");
            int sanskrit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maths A (75): ");
            int mathsA = Convert.ToInt32(Console.ReadLine());

            // Call MarksCalculate.Calculate to calculate total marks and percentage
            int totalMarks, totalPercentage;
            char grade;
            MarksCalculate.Calculate(english, sanskrit, mathsA, out totalMarks, out totalPercentage, out grade);

            // Create an instance of TotalResult to access PrintStudentDetails method
            TotalResult result = new TotalResult();
            result.TotalMarks = totalMarks;
            result.TotalPercentage = totalPercentage;
            result.Grade = grade;
            result.EnglishP = english;
            result.SanskritP = sanskrit;
            result.MathsAP = mathsA;

            // Display student details including marks
            Console.WriteLine(result.PrintStudentDetails());
        }
    }
}

