
namespace Decorator
{
    interface IComponent
    {
        string Operation();
    }

    class ConcreteComponent : IComponent
    {
        public virtual string Operation()
        {
            return "ConcreteComponent";
        }
    }
}

