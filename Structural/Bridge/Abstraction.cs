
namespace Bridge
{
    class Abstraction
    {
        protected readonly IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return $"Abstract: Base operation with\n{_implementation.OperationImplementation()}\n";
        }
    }

    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) :
            base (implementation) {}

        public override string Operation()
        {
            return $"Extendend abstraction: Extendend operation with\n{_implementation.OperationImplementation()}\n";
        }
    }
}

