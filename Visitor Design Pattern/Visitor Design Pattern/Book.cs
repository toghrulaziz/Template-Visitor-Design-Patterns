using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    internal class Book : IProduct
    {
        public string Name { get; }
        public double Price { get; }

        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
