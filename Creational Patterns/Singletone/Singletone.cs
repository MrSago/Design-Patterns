
namespace Singletone
{
    class Singletone
    {
        private Singletone() { }
        private static Singletone _instance;
        private static readonly object _mutex = new();
        public static Singletone GetInstance(string _value = null)
        {
            if (_instance == null)
            {
                lock (_mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new();
                        _instance.value = _value;
                    }
                }
            }
            return _instance;
        }
        private string value;
        public string Value { get => value; }
    }
}

