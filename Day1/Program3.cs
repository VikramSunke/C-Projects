
/* Class name: Program3.cs
 * This Program is used to add two numbers taking inputs from the user
 * */
namespace Day1     //Project name: Day1
{
    internal class Program3  // Class name: Program3.cs 
    {
        static void Main(string[] args)
        {
            int number1, number2, result;

            // Showing text to the user to easily understand that user need to  enter a number
            Console.Write("Enter first number: "); 

            ///<summary>
            ///The next line Takes the user input as of type string and it converts the string type to the integer type.
            /// Convert.ToInt32(Console.ReadLine());  : this line helps in converting any datatype to any datatype
            /// int.Parse(Console.ReadLine()); : this line helps in converting string datatype to any datatype
            /// </summary>
            
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            number2=int.Parse(Console.ReadLine());

            result = number1 + number2; // adding two numbers and storing the sum in result variable

            Console.WriteLine("Addition of {0} and {1} is {2}", number1, number2, result); // Printing the addition result using composite formatting

            Console.WriteLine("Addition of "+number1+" and "+number2+" is "+result); // Another way of printing the addition result using concatenation


        }
    }
}