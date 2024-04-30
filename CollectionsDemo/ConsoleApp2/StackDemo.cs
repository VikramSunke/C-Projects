using System.Collections;
namespace ConsoleApp2
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            //Stack studentNames=new Stack();  // followa Last In First Out
            //studentNames.Push("vikram");
            //studentNames.Push("anil");
            //studentNames.Push("ajay");
            //studentNames.Push("bran");
            //studentNames.Pop();
            //foreach(var student in studentNames) 
            //{ 
            //    Console.WriteLine(student);

            //}

            //Console.WriteLine(studentNames.Count);

            //string topElement=(string)studentNames.Peek();

            //Console.WriteLine("Top Element: {0}",topElement);

            //Console.WriteLine(studentNames.Peek());

            Stack<Product> shoppingCart = new Stack<Product>();
            shoppingCart.Push(new Product("redmi", "black", 15000));
            shoppingCart.Push(new Product("poco", "yellow", 35000));
            shoppingCart.Push(new Product("vivo", "blue", 25000));
            shoppingCart.Push(new Product("apple", "gold", 150000));

            DisplayShoppingCart(shoppingCart);

            if(shoppingCart.Count > 0)
            {
                Product popElement= shoppingCart.Pop();   // Removes elements which is on top
                Console.WriteLine("\nPop Element: ");
                Console.WriteLine($"{popElement.Name} {popElement.Color} {popElement.Price}\n");

            }
            Product peekElement = shoppingCart.Peek();  //Displays element which is on top
            Console.WriteLine("Peek Element:");
            Console.WriteLine($"{peekElement.Name} {peekElement.Color} {peekElement.Price}\n");


            Console.WriteLine("Cart count: "+shoppingCart.Count);

            shoppingCart.Clear();   // clears all cart items
            DisplayShoppingCart(shoppingCart);


        }
        static void DisplayShoppingCart(Stack<Product> shoppingCart)
        {
            Console.WriteLine("List of products: ");
            foreach(Product product in shoppingCart)
            {
                Console.WriteLine($"{product.Name} {product.Color} {product.Price}");
            }
        }
    }
    class Product
    {
        public string Name { get;}
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
