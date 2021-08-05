
using System;

namespace Factory_Method
{
    static class AppMain
    {
        static HelloFactory Init()
        {
            return OperatingSystem.IsWindows() ? new WinFactory() :
                   OperatingSystem.IsLinux() ? new LinuxFactory() :
            throw new Exception("Unknown OS\n");
        }
        static void Main(string[] args)
        {
            HelloFactory helloFactory = Init();
            Console.Write(helloFactory.HelloOS.GetHello());
            Console.ReadKey(true);
        }
    }
}

