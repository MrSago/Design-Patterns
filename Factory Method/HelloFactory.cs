
namespace Factory_Method
{
    abstract class HelloFactory
    {
        public IHelloOS HelloOS;
        public HelloFactory()
        {
            HelloOS = CreateObj();
        }
        public abstract IHelloOS CreateObj();
    }
    class WinFactory : HelloFactory
    {
        public override IHelloOS CreateObj()
        {
            return new HelloWin();
        }
    }
    class LinuxFactory : HelloFactory
    {
        public override IHelloOS CreateObj()
        {
            return new HelloLinux();
        }
    }
}

