using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    internal interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
        double GetTotalCost();
    }
}
