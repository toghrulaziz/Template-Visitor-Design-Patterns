using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    internal class ShoppingCart
    {
        private List<IProduct> _products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            _products.Remove(product);
        }

        public double CalculateTotalCost()
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitor();
            foreach (IProduct product in _products)
            {
                product.Accept(visitor);
            }
            return visitor.GetTotalCost();
        }
    }
}
