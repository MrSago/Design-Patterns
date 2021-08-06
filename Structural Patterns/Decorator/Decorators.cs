
namespace Decorator
{
    abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void SetComponent(IComponent component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            if (_component == null)
            {
                return string.Empty;
            }
            return _component.Operation();
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) :
            base(component) {}

        public override string Operation()
        {
            return $"ConcretetDecoratorA({base.Operation()})";
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) :
            base(component) {}

        public override string Operation()
        {
            return $"ConcretetDecoratorB({base.Operation()})";
        }
    }
}

