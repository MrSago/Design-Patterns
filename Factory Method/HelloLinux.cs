
namespace Factory_Method
{
    class HelloLinux : IHelloOS
    {
        private string hello_str;
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

