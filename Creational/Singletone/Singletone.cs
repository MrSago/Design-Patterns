using System;

namespace Singletone;

class Singletone
{
    private Singletone() { }

    private static Singletone? _instance;
    private static readonly object _mutex = new();

    public static Singletone GetInstance(string? value = null)
    {
        if (_instance is not null)
        {
            return _instance;
        }

        lock (_mutex)
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));
            _instance = new() { _value = value };
        }
        return _instance;
    }

    public static void Reset()
    {
        _instance = null;
    }

    private string _value = string.Empty;
    public string Value
    {
        get => _value;
        private init => _value = value;
    }
}
