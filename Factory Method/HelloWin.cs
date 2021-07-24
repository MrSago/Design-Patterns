
namespace Factory_Method
{
    class HelloWin : IHelloOS
    {
        private string hello_str;
        public HelloWin()
        {
            hello_str = "Hello World from Windows!\n";
        }
        public string GetHello()
        {
            return hello_str;
        }
    }
}

