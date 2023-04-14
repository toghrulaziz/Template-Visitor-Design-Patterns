using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    internal interface IProduct
    {
        string Name { get; }
        double Price { get; }
        void Accept(IVisitor visitor);
    }
}
