namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mobile1 = new Product();

            mobile1.PName = "vivo";
            mobile1.PDescription = "6gb 128 gb 5000mah";
            mobile1.PColor = "Blue";
            mobile1.PPrice = 15000;
            
            Console.WriteLine("{0} {1} {2} {3} ", mobile1.PName, mobile1.PDescription, mobile1.PColor, mobile1.PPrice);


            Product mobile2 = new Product();
            mobile2.ProductInformation("redmi", "4gb 64gb 4000mah", "black", 13000);
            Console.WriteLine(mobile2.AddProductDetails());
        }


    }
}
