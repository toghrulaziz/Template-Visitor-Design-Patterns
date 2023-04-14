using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    internal class Fruit : IProduct
    {
        public string Name { get; }
        public double Price { get; }
        public double Weight { get; }

        public Fruit(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
