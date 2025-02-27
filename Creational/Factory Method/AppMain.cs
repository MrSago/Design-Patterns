using System;
using Factory_Method;

static HelloFactory Init() =>
    OperatingSystem.IsWindows() ? new WinFactory()
    : OperatingSystem.IsLinux() ? new LinuxFactory()
    : throw new Exception("Unknown OS\n");

HelloFactory helloFactory = Init();
Console.WriteLine(helloFactory.HelloOS.GetHello());
