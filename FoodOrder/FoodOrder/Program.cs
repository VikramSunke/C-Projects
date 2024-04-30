namespace FoodOrder
{
    public abstract class FoodOrder
    {

        public abstract void CalculateTotalPrice(decimal amount);
        //public abstract string GetOrderDetails(string details);
    }
    public class OnlineOrder : FoodOrder
    {
        public override void CalculateTotalPrice(decimal amount)
        {
            Console.WriteLine(amount);
        }
        //public override string GetOrderDetails(string details)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class InstoreOrder : FoodOrder
    {
        public override void CalculateTotalPrice(decimal amount)
        {
            Console.WriteLine(amount);
        }
        //public override string GetOrderDetails(string details)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class FoodOrderPlatform
    {
        public void Checkout(FoodOrder foodOrder, decimal amount)
        {
            foodOrder.CalculateTotalPrice(amount);
        }
    }
    public class Program
    {
        public static void Main()
        {
            FoodOrderPlatform foodOrderPlatform = new FoodOrderPlatform();

            FoodOrder onlineOrder=new OnlineOrder();
            FoodOrder inStoreOrder= new InstoreOrder();

            foodOrderPlatform.Checkout(onlineOrder, 200);
            foodOrderPlatform.Checkout(inStoreOrder, 100);

            //Console.WriteLine("Hello, World!");
        }
    }
}
