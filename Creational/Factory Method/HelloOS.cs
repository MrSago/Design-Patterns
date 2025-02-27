namespace Factory_Method;

interface IHelloOS
{
    string GetHello();
}

class HelloWin : IHelloOS
{
    private readonly string _helloString;

    public HelloWin()
    {
        _helloString = "Hello World from Windows!\n";
    }

    public string GetHello()
    {
        return _helloString;
    }
}

class HelloLinux : IHelloOS
{
    private readonly string _helloString;

    public HelloLinux()
    {
        _helloString = "Hello World from Linux!\n";
    }

    public string GetHello()
    {
        return _helloString;
    }
}
