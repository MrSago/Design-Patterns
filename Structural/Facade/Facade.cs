using System;
using System.Text;

namespace Facade;

class FacadeClass
{
    protected Subsystem1 _subsystem1;
    protected Subsystem2 _subsystem2;

    public FacadeClass()
    {
        _subsystem1 = new();
        _subsystem2 = new();
    }

    public FacadeClass(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        _subsystem1 = subsystem1;
        _subsystem2 = subsystem2;
    }

    public string OperationResult()
    {
        return new StringBuilder()
            .AppendLine("Facade init Subsystem1:")
            .AppendLine(_subsystem1.Operation1())
            .AppendLine(_subsystem1.Operation2())
            .AppendLine()
            .AppendLine("Facade init Subsystem2")
            .AppendLine(_subsystem2.Operation1())
            .AppendLine(_subsystem2.Operation2())
            .ToString();
    }
}

public class Example<T>(T value)
{
    public T Value { get; set; } = value;

    public void DisplayValue()
    {
        Console.WriteLine($"Value: {Value} | Type: {nameof(Example<T>)}");
    }
}
