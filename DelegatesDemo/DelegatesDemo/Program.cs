using System;

namespace DelegatesDemo
{
    public delegate void StudentMarksMethod(int Maths, int Physics, int Chemistry);

    public class StudentMarks
    {
        public void Addition(int Maths, int Physics, int Chemistry)
        {
            Console.WriteLine("\nAddition of {0}, {1}, and {2} is {3}", Maths, Physics, Chemistry, Maths + Physics + Chemistry);
        }

        public void Percentage(int Maths, int Physics, int Chemistry)
        {
            int totalMarks = Maths + Physics + Chemistry;
            float percentage = (float)totalMarks / 300 * 100;
            Console.WriteLine("\nPercentage: {0}%", percentage);
        }

        public void Average(int Maths, int Physics, int Chemistry)
        {
            float average = (Maths + Physics + Chemistry) / 3;
            Console.WriteLine("\nAverage Marks: {0}", average);
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StudentMarks studentMarks = new StudentMarks();

            StudentMarksMethod obj1, obj2, obj3, obj4,obj5;
            obj1 = new StudentMarksMethod(studentMarks.Addition);
            obj2 = new StudentMarksMethod(studentMarks.Percentage);
            obj3 = new StudentMarksMethod(studentMarks.Average);


            Console.WriteLine("\nAddition of Marks:");
            obj1(90, 80, 70);

            Console.WriteLine("\n Percentage of Marks:");
            obj2(90, 80, 60);

            Console.WriteLine("\n Average of Marks:");
            obj3(90, 80, 70);

           

            
            
            obj4 = obj1 +obj2+ obj3;


            obj4(90, 90, 100);   //calling three methods

            
            

            obj4 -= obj2;    // This removes obj2 method from obj4 delegate

            Console.WriteLine("\nCalling obj5:");
            obj4(80, 80, 80);

            Console.ReadKey();
        }
    }
}