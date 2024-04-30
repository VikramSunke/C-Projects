
/* Class name: Program4.cs
 * This Program is used to declare variables with all data types and printing them
 * */
namespace Day1     //Project name: Day1
{
    internal class Program4  // Class name: Program4.cs 
    {
        static void Main(string[] args)
        {
            // Declaring variables with all data types
            int intVar;
            uint unsignedIntVar;
            short shortVar;
            ushort unsignedShortVar;
            long longVar;
            ulong unsignedLongVar;
            byte byteVar;
            sbyte signedByteVar;
            float floatVar;
            double doubleVar;
            decimal decimalVar;
            char charVar;
            string stringVar;
            bool boolVar;

            ///<summary>
            ///int integerVar;              Sample value: 123, Range: -2,147,483,648 to 2,147,483,647
            ///uint unsignedIntVar;         Sample value: 456, Range: 0 to 4,294,967,295
            ///short shortVar;              Sample value: -123, Range: -32,768 to 32,767
            ///ushort unsignedShortVar;     Sample value: 789, Range: 0 to 65,535
            ///long longVar;                Sample value: -123456789, Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ///ulong unsignedLongVar;       Sample value: 987654321, Range: 0 to 18,446,744,073,709,551,615
            ///byte byteVar;                Sample value: 100, Range: 0 to 255
            ///sbyte signedByteVar;         Sample value: -50, Range: -128 to 127
            ///float floatVar;              Sample value: 12.34, Range: ±1.5 × 10^−45 to ±3.4 × 10^38
            ///double doubleVar;            Sample value: 56.789, Range: ±5.0 × 10^−324 to ±1.7 × 10^308
            ///decimal decimalVar;          Sample value: 123.456, Range: ±1.0 × 10^−28 to ±7.9 × 10^28
            ///char charVar;                Sample value: 'A', Range: '\u0000' to '\uffff'
            ///string stringVar;            Sample value: "Hello", Range: 0 to approximately 2 billion Unicode characters
            ///bool boolVar;                Sample value: True, Range: True or False
            ///</summary>
        
            Console.WriteLine("Enter integer value:");
            intVar=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter unsigned integer value:");
            unsignedIntVar= Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter short value:");
            shortVar=Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter an unsigned short value: ");
            unsignedShortVar = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Enter a long value: ");
            longVar = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter an unsigned long value: ");
            unsignedLongVar = Convert.ToUInt64(Console.ReadLine());

            Console.Write("Enter a byte value: ");
            byteVar = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter a signed byte value: ");
            signedByteVar = Convert.ToSByte(Console.ReadLine());

            Console.Write("Enter a float value: ");
            floatVar = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter a double value: ");
            doubleVar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a decimal value: ");
            decimalVar = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter a character: ");
            charVar = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a string: ");
            stringVar = Console.ReadLine();

            Console.Write("Enter a boolean value (T/F): ");
            boolVar = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Integer: " + intVar);
            Console.WriteLine("Unsigned Integer: " + unsignedIntVar);
            Console.WriteLine("Short: " + shortVar);
            Console.WriteLine("Unsigned Short: " + unsignedShortVar);
            Console.WriteLine("Long: " + longVar);
            Console.WriteLine("Unsigned Long: " + unsignedLongVar);
            Console.WriteLine("Byte: " + byteVar);
            Console.WriteLine("Signed Byte: " + signedByteVar);
            Console.WriteLine("Float: " + floatVar);
            Console.WriteLine("Double: " + doubleVar);
            Console.WriteLine("Decimal: " + decimalVar);
            Console.WriteLine("Character: " + charVar);
            Console.WriteLine("String: " + stringVar);
            Console.WriteLine("Boolean: " + boolVar);

            Console.ReadKey();


        }
    }
}
