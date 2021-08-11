
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
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} + {GetType().Name}");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} + {GetType().Name}");
        }
    }

    class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} + {GetType().Name}");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} + {GetType().Name}");
        }
    }
}

