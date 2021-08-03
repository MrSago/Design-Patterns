
using System;

namespace Factory_Method
{
    static class AppMain
    {
        static HelloFactory Init()
        {
            if (OperatingSystem.IsWindows())
            {
                return new WinFactory();
            }
            else if (OperatingSystem.IsLinux())
            {
                return new LinuxFactory();
            }
            else
            {
                throw new Exception("Unknown OS\n");
            }
        }
        static void Main(string[] args)
        {
            HelloFactory helloFactory = Init();
            Console.WriteLine(helloFactory.HelloOS.GetHello());
            Console.ReadKey(true);
        }
    }
}

