using GenericsDemo;
using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    public class StudentOperations
    {
        private List<StudentModal<int, string>> students = new List<StudentModal<int, string>>();

        public StudentModal<int, string> CreateStudent(int id, string name, int age)
        {
            var student = new StudentModal<int, string> { Id = id, Name = name, Age = age };
            students.Add(student);
            return student;
        }

        public void DisplayStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"\nId: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }

        public void UpdateStudent(int id, string newName, int newAge)
        {
            var student = students.Find(s => s.Id.Equals(id));
            if (student != null)
            {
                student.Name = newName;
                student.Age = newAge;
                Console.WriteLine($"\nStudent with Id {id} updated successfully.");
            }
            else
            {
                Console.WriteLine($"\nStudent with Id {id} not found.");
            }
        }

        public void DeleteStudent(int id)
        {
            var student = students.Find(s => s.Id.Equals(id));
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine($"\nStudent with Id {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"\nStudent with Id {id} not found.");
            }
        }
    }
}
