
namespace Singletone
{
    class Singletone
    {
        private Singletone() {}

        private static Singletone _instance;
        private static readonly object _mutex = new();

        public static Singletone GetInstance(string value = null)
        {
            if (_instance == null)
            {
                lock (_mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new();
                        _instance._value = value;
                    }
                }
            }
            return _instance;
        }

        private string _value;
        public string Value => _value;
    }
}

