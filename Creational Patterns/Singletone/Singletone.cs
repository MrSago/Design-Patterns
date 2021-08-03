
namespace Singletone
{
    class Singletone
    {
        private Singletone() { }
        private static Singletone instance;
        private static readonly object mutex = new();
        public static Singletone GetInstance(string _value)
        {
            if (instance == null)
            {
                lock (mutex)
                {
                    if (instance == null)
                    {
                        instance = new();
                        instance.value = _value;
                    }
                }
            }
            return instance;
        }
        private string value;
        public string Value
        {
            get => value;
        }
    }
}

