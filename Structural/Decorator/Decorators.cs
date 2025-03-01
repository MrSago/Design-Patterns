namespace Decorator;

abstract class Decorator(IComponent component) : IComponent
{
    protected IComponent _component = component;

    public void SetComponent(IComponent component)
    {
        _component = component;
    }

    public virtual string Operation()
    {
        return _component.Operation();
    }
}

class ConcreteDecoratorA(IComponent component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcretetDecoratorA({base.Operation()})";
    }
}

class ConcreteDecoratorB(IComponent component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcretetDecoratorB({base.Operation()})";
    }
}
