using System;
using System.Text;

namespace Project02
{
    internal class TotalResult  // This class represents the total result of a student.
    {
        // Properties to store the total marks, total percentage, grade, and marks for each subject.
        public int TotalMarks { get; set; }
        public int TotalPercentage { get; set; }
        public char Grade { get; set; }
        public int EnglishP { get; set; }
        public int SanskritP { get; set; }
        public int MathsAP { get; set; }

        // Method to print student details including marks.
        public string PrintStudentDetails()
        {
            StringBuilder sb = new StringBuilder();

            // Appending total marks, total percentage, and grade to the string.
            sb.Append($"Total Marks = {TotalMarks}, Total Percentage = {TotalPercentage}, Grade = {Grade}{Environment.NewLine}");
            // Appending marks for each subject to the string.
            sb.Append($"English Marks = {EnglishP}, Sanskrit Marks = {SanskritP}, Maths Marks = {MathsAP}");

            // Converting StringBuilder to string and returning.
            return sb.ToString();
        }
    }

    internal class MarksCalculate
    {
        // Method to calculate total marks, percentage, and grade.

        public static void Calculate(int english, int sanskrit, int mathsA, out int totalMarks, out int totalPercentage, out char grade)
        {
            // Calculating total marks.
            totalMarks = english + sanskrit + mathsA;

            // Calculating total percentage.
            totalPercentage = (totalMarks * 100) / 275;

            // Determining grade based on the total percentage using a switch statement.
            grade = totalPercentage switch
            {
                >= 90 => 'A',
                >= 80 => 'B',
                >= 70 => 'C',
                >= 60 => 'D',
                >= 50 => 'E',
                _ => 'F',
            };
        }
    }
}
