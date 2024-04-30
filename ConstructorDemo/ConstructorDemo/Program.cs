namespace ConstructorDemo
{
    internal class Program
    {
        public class Calculator
        {
            private string name;
            private int id;
            public Calculator(string Name,int id)
            {
                this.name = Name;
                this.id=id;
            }
        }
        public class Cal2 : Calculator
        {
        
            public Cal2(int Age, int Id) : base("caskn", 21)
            {
                this.
            }
        }

        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator("viksaxa",21);
            Console.WriteLine();
            Cal2 cal = new Cal2(21,2);
            //Calculator2 cal = new Calculator2(20,10);
        }
    }
}
