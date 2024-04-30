using System;
using System.Collections;

namespace CollectionsDemo
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class SortedListExample
    {
        private SortedList sortedList = new SortedList();

        public void AddPerson(Person person)
        {
            if (!sortedList.ContainsKey(person.Name))
                sortedList.Add(person.Name, person);
            else
                Console.WriteLine($"Person with name '{person.Name}' already exists in the list.");
        }

        public int? GetAge(string name)
        {
            if (sortedList.ContainsKey(name))
            {
                Person person = (Person)sortedList[name];
                return person.Age;
            }
            else
            {
                Console.WriteLine($"Person with name '{name}' not found in the list.");
                return null;
            }
        }

        public void PrintList()
        {
            Console.WriteLine("People in the sorted list:");
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine($"Name: {key}, Age: {((Person)sortedList[key]).Age}");
            }
        }

        public void RemovePerson(string name)
        {
            if (sortedList.ContainsKey(name))
                sortedList.Remove(name);
            else
                Console.WriteLine($"Person with name '{name}' not found in the list.");
        }

        public int Count()
        {
            return sortedList.Count;
        }

        public void Clear()
        {
            sortedList.Clear();
        }
    }

    public class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedListExample sortedListExample = new SortedListExample();

            sortedListExample.AddPerson(new Person("Ravi", 25));
            sortedListExample.AddPerson(new Person("Priya", 30));
            sortedListExample.AddPerson(new Person("Vikram", 35));

            int? ageOfPriya = sortedListExample.GetAge("Priya");
            Console.WriteLine("Age of Priya: " + (ageOfPriya.HasValue ? ageOfPriya.ToString() : "Not found"));

            sortedListExample.PrintList();

            sortedListExample.RemovePerson("Ravi");

            Console.WriteLine("Is Ravi in the list? " + (sortedListExample.GetAge("Ravi") != null ? "Yes" : "No"));

            Console.WriteLine("Count of people in the list: " + sortedListExample.Count());

            sortedListExample.Clear();

            Console.WriteLine("After clearing, the count of people in the list: " + sortedListExample.Count());
        }
    }
}
