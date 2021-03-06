
using System;

namespace Factory_Method
{
    static class AppMain
    {
        static HelloFactory Init() =>
            OperatingSystem.IsWindows() ? new WinFactory() :
            OperatingSystem.IsLinux() ? new LinuxFactory() :
            throw new Exception("Unknown OS\n");

        static void Main()
        {
            HelloFactory helloFactory = Init();
            Console.Write(helloFactory.HelloOS.GetHello());
            _ = Console.ReadKey(true);
        }
    }
}

