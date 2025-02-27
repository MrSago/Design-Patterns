namespace Factory_Method;

abstract class HelloFactory
{
    public IHelloOS HelloOS;

    public abstract IHelloOS CreateObj();

    public HelloFactory()
    {
        HelloOS = CreateObj();
    }
}

class WinFactory : HelloFactory
{
    public override IHelloOS CreateObj() => new HelloWin();
}

class LinuxFactory : HelloFactory
{
    public override IHelloOS CreateObj() => new HelloLinux();
}
