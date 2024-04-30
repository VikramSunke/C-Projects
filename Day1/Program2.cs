
/* Class name: Program2.cs
 * This Program is used to declare variables with different data types and printing them
 * */
namespace Day1     //Project name: Day1
{
    internal class Program2  // Class name: Program2.cs 
    {
        static void Main(string[] args)
        {
            int id = 5;             // Declaring variable "id" as an integer type
            string name = "vikram"; // Declaring variable "name" as string type
            float height = 5.81F;   // Declaring variable "height" as a float value
            char gender = 'M';       // Declaring variable "gender" as character type
            byte age = 22;          // Declaring variable "age" as byte type

            //Printing all the  details using different ype of print statements
            Console.WriteLine("ID : {0}", id);
            Console.WriteLine("Name : "+ name);
            Console.WriteLine("Height : {0:F}", height);
            Console.Write("Age : {0}",age);
            Console.Write(" Gender : " + gender); //Executes in the same line

            // Waiting for the user to press a key before exiting
            Console.ReadKey();

        }
    }
}
