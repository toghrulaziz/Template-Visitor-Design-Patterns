using System.Xml;

namespace Template_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pepperoniPizza = new PepperoniPizza();
            Pizza margheritaPizza = new MargheritaPizza();

            Console.WriteLine("Making a pepperoni pizza...");
            pepperoniPizza.Make();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Making a margherita pizza...");
            margheritaPizza.Make();
        }
    }
}