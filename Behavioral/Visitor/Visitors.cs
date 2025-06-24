
using System;

namespace Visitor
{
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);
        void VisitConcreteComponentB(ConcreteComponentB element);
    }

    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{ConcreteComponentA.ExclusiveMethodOfConcreteComponentA()} + {GetType().Name}");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{ConcreteComponentB.SpecialMethodOfConcreteComponentB()} + {GetType().Name}");
        }
    }

    class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{ConcreteComponentA.ExclusiveMethodOfConcreteComponentA()} + {GetType().Name}");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{ConcreteComponentB.SpecialMethodOfConcreteComponentB()} + {GetType().Name}");
        }
    }
}

