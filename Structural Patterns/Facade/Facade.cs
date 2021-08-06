
namespace Facade
{
    class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade()
        {
            _subsystem1 = new();
            _subsystem2 = new();
        }

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string OperationResult()
        {
            return
                "Facade init Subsystem1:\n" +
                $"{_subsystem1.Operation1()}\n" +
                $"{_subsystem1.Operation2()}\n\n" +
                "Facade init Subsystem2\n" +
                $"{_subsystem2.Operation1()}\n" +
                $"{_subsystem2.Operation2()}\n";
        }
    }
}

