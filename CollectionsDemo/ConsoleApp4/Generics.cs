using System;
using System.Collections.Generic;

public class ActionMethods<T>
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Can't pop from an empty stack.");
        }

        T poppedItem = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return poppedItem;
    }

    public T Peek()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Can't peek from an empty stack.");
        }

        return items[items.Count - 1];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public int Count()
    {
        return items.Count;
    }

    public void Clear()
    {
        items.Clear();
    }
}

class Generics
{
    static void Main(string[] args)
    {
        ActionMethods<Person<string, int, float>> actionMethods = new ActionMethods<Person<string, int, float>>();

        Console.Write("Enter the name of the first person: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter the age of the first person: ");
        int firstAge = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the first person: ");
        float firstHeight = float.Parse(Console.ReadLine());
        actionMethods.Push(new Person<string, int, float>(firstName, firstAge, firstHeight));

        Console.Write("Enter the name of the second person: ");
        string secondName = Console.ReadLine();
        Console.Write("Enter the age of the second person: ");
        int secondAge = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of the second person: ");
        float secondHeight = float.Parse(Console.ReadLine());
        actionMethods.Push(new Person<string, int, float>(secondName, secondAge, secondHeight));

        Console.WriteLine("Top of the stack: " + actionMethods.Peek());

        while (!actionMethods.IsEmpty())
        {
            Console.WriteLine("Popped item: " + actionMethods.Pop());
        }

        Console.WriteLine("Stack is empty now. Count: " + actionMethods.Count());

        actionMethods.Push(new Person<string, int, float>("vikram", 35, 180.5f));
        actionMethods.Push(new Person<string, int, float>("shiva", 28, 165.2f));

        Console.WriteLine("After adding two more persons, count: " + actionMethods.Count());

        actionMethods.Clear();
        Console.WriteLine("Stack cleared. Count: " + actionMethods.Count());

        Console.ReadKey();
    }
}

public class Person<U, V, S>
{
    public U Name { get; set; }
    public V Age { get; set; }
    public S Height { get; set; }

    public Person(U name, V age, S height)
    {
        Name = name;
        Age = age;
        Height = height;
    }

   
}
