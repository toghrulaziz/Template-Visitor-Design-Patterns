using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Design_Pattern
{
    internal class PepperoniPizza : Pizza
    {
        protected override void AddSauce()
        {
            Console.WriteLine("   Adding tomato sauce...");
        }

        protected override void AddToppings()
        {
            Console.WriteLine("   Adding pepperoni toppings...");
        }
    }
}
