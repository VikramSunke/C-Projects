using System;
using System.Collections.Generic;

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
    private SortedList<string, Person> sortedList = new SortedList<string, Person>();

    public void AddPerson(Person person)
    {
        sortedList.Add(person.Name, person);
    }

    public int GetAge(string name)
    {
        if (sortedList.ContainsKey(name))
            return sortedList[name].Age;
        else
            return -1; // Or any default value you choose
    }

    public void PrintList()
    {
        Console.WriteLine("People in the sorted list:");
        foreach (var pair in sortedList)
        {
            Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value.Age}");
        }
    }

    public void RemovePerson(string name)
    {
        sortedList.Remove(name);
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

class SortedListDemo
{
    static void Main(string[] args)
    {
        SortedListExample sortedListExample = new SortedListExample();

        sortedListExample.AddPerson(new Person("Ravi", 25));
        sortedListExample.AddPerson(new Person("Priya", 30));
        sortedListExample.AddPerson(new Person("Vikram", 35));

        Console.WriteLine("Age of Priya: " + sortedListExample.GetAge("Priya"));

        sortedListExample.PrintList();

        sortedListExample.RemovePerson("Ravi");

        bool isRaviInList = sortedListExample.GetAge("Ravi") != -1;
        Console.WriteLine("Is Ravi in the list? " + (isRaviInList ? "Yes" : "No"));

        Console.WriteLine("Count of people in the list: " + sortedListExample.Count());

        sortedListExample.Clear();

        Console.WriteLine("After clearing, the count of people in the list: " + sortedListExample.Count());
    }
}
