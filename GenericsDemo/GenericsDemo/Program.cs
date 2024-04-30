namespace GenericsDemo
{
    using CollectionsDemo;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            StudentOperations operations = new StudentOperations();
            StudentModal<int, string> student1 = operations.CreateStudent(1, "vikram", 22);
            StudentModal<int, string> student2 = operations.CreateStudent(2, "shiva", 24);
            operations.DisplayStudents();

            operations.UpdateStudent(1, "Johnny", 21);
            operations.DisplayStudents();

            operations.DeleteStudent(2);
            operations.DisplayStudents();

            Console.ReadKey();
        }
    }

}
