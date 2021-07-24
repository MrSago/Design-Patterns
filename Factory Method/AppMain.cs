
using System;

namespace Factory_Method
{
    static class AppMain
    {
        static HelloFactory HF;
        static void Init()
        {
            if (OperatingSystem.IsWindows())
            {
                HF = new WinFactory();
            }
            else if (OperatingSystem.IsLinux())
            {
                HF = new LinuxFactory();
            }
            else
            {
                throw new Exception("Unknown OS\n");
            }
        }
        static void Main(string[] args)
        {
            Init();
            Console.WriteLine(HF.HelloOS.GetHello());
            Console.ReadKey();
        }
    }
}

