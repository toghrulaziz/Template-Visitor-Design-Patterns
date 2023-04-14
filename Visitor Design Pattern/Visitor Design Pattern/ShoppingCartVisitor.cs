using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    internal class ShoppingCartVisitor : IVisitor
    {
        private double _totalCost = 0;

        public void Visit(Book book)
        {
            _totalCost += book.Price;
        }

        public void Visit(Fruit fruit)
        {
            _totalCost += fruit.Price * fruit.Weight;
        }

        public double GetTotalCost()
        {
            return _totalCost;
        }
    }
}
