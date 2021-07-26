
namespace Factory_Method
{
    interface IHelloOS
    {
        string GetHello();
    }

    class HelloWin : IHelloOS
    {
        private readonly string hello_str;
        public HelloWin()
        {
            hello_str = "Hello World from Windows!\n";
        }
        public string GetHello()
        {
            return hello_str;
        }
    }
    class HelloLinux : IHelloOS
    {
        private readonly string hello_str;
        public HelloLinux()
        {
            hello_str = "Hello World from Linux!\n";
        }
        public string GetHello()
        {
            return hello_str;
        }
    }
}

