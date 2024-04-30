using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: FormatException
            try
            {
                Console.WriteLine("Example 1: FormatException");
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();
                int number = Convert.ToInt32(userInput);
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException occurred: {ex.Message}");
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Example 2: DivideByZeroException
            try
            {
                Console.WriteLine("\nExample 2: DivideByZeroException");
                Console.WriteLine("Enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {a} and {b}");

                Console.WriteLine("Attempting to perform a division...");
                int result = PerformDivision(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException occurred: {ex.Message}");
                Console.WriteLine("Division by zero is not allowed.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException occurred: {ex.Message}");
                Console.WriteLine("Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Example 3: ArgumentException
            try
            {
                Console.WriteLine("\nExample 3: ArgumentException");
                Console.WriteLine("Processing input...");
                Console.WriteLine("Enter a positive value:");
                int value = Convert.ToInt32(Console.ReadLine());
                ProcessInput(value); // This will throw ArgumentException
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException occurred: {ex.Message}");
                Console.WriteLine("Please provide a positive value.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException occurred: {ex.Message}");
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Example 4: InvalidOperationException
            try
            {
                Console.WriteLine("\nExample 4: InvalidOperationException");
                Console.WriteLine("Iterating through names...");
                string[] names = { "John", "Doe", null };
                foreach (var name in names)
                {
                    if (name.Length == 4)
                    {
                        throw new InvalidOperationException("Name cannot have 4 characters.");
                    }
                    Console.WriteLine(name);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException occurred: {ex.Message}");
                Console.WriteLine("An invalid operation was detected while processing names.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            // Example 1: IndexOutOfRangeException
            try
            {
                Console.WriteLine("Example 1: IndexOutOfRangeException");
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Accessing an element beyond the array's bounds...");
                int value = numbers[3]; // Trying to access index 3, which is out of bounds
                Console.WriteLine($"Value at index 3: {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException occurred: {ex.Message}");
                Console.WriteLine("Index is out of the array's bounds.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Example 2: ArrayTypeMismatchException
            try
            {
                Console.WriteLine("\nExample 2: ArrayTypeMismatchException");
                object[] objects = new string[3]; // Assigning string array to object array
                Console.WriteLine("Assigning an array of one type to an array of another type...");
                objects[0] = 10; // Trying to assign an int to the string array
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine($"ArrayTypeMismatchException occurred: {ex.Message}");
                Console.WriteLine("Array type mismatch occurred.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static int PerformDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        static void ProcessInput(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Input value must be positive.");
            }
        }
    }
}
