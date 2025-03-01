namespace Bridge;

class Abstraction(IImplementation implementation)
{
    protected readonly IImplementation _implementation = implementation;

    public virtual string Operation()
    {
        return $"Abstract: Base operation with\n{_implementation.OperationImplementation()}";
    }
}

class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
{
    public override string Operation()
    {
        return $"Extendend abstraction: Extendend operation with\n{_implementation.OperationImplementation()}";
    }
}
