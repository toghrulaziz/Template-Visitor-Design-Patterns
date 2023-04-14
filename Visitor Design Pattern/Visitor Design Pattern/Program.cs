namespace Visitor_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(new Book("Design Patterns: Elements of Reusable Object-Oriented Software", 39.99));
            cart.AddProduct(new Fruit("Apple", 0.5, 2.5));
            cart.AddProduct(new Fruit("Banana", 0.25, 5.0));

            double totalCost = cart.CalculateTotalCost();
            Console.WriteLine($"Total cost of products in cart: ${totalCost}");

            Console.ReadKey();
        }
    }
}