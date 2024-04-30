using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            // Non-generic Stack
            Stack studentNames = new Stack();  // Follows Last In First Out
            studentNames.Push("vikram");
            studentNames.Push("anil");
            studentNames.Push("ajay");
            studentNames.Push("bran");
            studentNames.Pop();
            foreach (var student in studentNames)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Count: " + studentNames.Count);

            // Generic Stack
            Stack<Product> shoppingCart = new Stack<Product>();
            shoppingCart.Push(new Product("redmi", "black", 15000));
            shoppingCart.Push(new Product("poco", "yellow", 35000));
            shoppingCart.Push(new Product("vivo", "blue", 25000));
            shoppingCart.Push(new Product("apple", "gold", 150000));

            DisplayShoppingCart(shoppingCart);

            if (shoppingCart.Count > 0)
            {
                Product popElement = shoppingCart.Pop();   // Removes elements which are on top
                Console.WriteLine("\nPop Element: ");
                Console.WriteLine($"{popElement.Name} {popElement.Color} {popElement.Price}\n");

            }
            if (shoppingCart.Count > 0)
            {
                Product peekElement = shoppingCart.Peek();  // Displays element which is on top
                Console.WriteLine("Peek Element:");
                Console.WriteLine($"{peekElement.Name} {peekElement.Color} {peekElement.Price}\n");
            }

            Console.WriteLine("Cart count: " + shoppingCart.Count);

            shoppingCart.Clear();   // Clears all cart items
            DisplayShoppingCart(shoppingCart);
        }

        static void DisplayShoppingCart(Stack<Product> shoppingCart)
        {
            Console.WriteLine("List of products: ");
            foreach (Product product in shoppingCart)
            {
                Console.WriteLine($"{product.Name} {product.Color} {product.Price}");
            }
        }
    }

    class Product
    {
        public string Name { get; }
        public string Color { get; }
        public double Price { get; }

        public Product(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
