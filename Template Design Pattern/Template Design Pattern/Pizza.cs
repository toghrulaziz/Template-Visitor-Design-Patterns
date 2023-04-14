using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Design_Pattern
{
    abstract class Pizza
    {
        public void Make()
        {
            PrepareDough();
            AddSauce();
            AddToppings();
            BakePizza();
        }

        protected void PrepareDough()
        {
            Console.WriteLine("   Preparing pizza dough...");
        }

        protected void BakePizza()
        {
            Console.WriteLine("   Baking pizza...");
        }

        
        protected abstract void AddSauce();

        protected abstract void AddToppings();
    }
}
