
using System;
using System.Threading;

namespace Singletone
{
    static class AppMain
    {
        static bool done = false;
        static readonly EventWaitHandle ewh = new(false, EventResetMode.AutoReset);

        static void InitIntance(int thNum, string value)
        {
            Singletone singletone = Singletone.GetInstance(value);
            Console.WriteLine($"Thread{thNum}: Hash={singletone.GetHashCode()} | Value={singletone.Value}");
        }

        static void ThreadBodyOne(string value)
        {
            InitIntance(1, value);
            done = true;
            ewh.Set();
        }

        static void ThreadBodyTwo(string value)
        {
            while (!done)
            {
                ewh.WaitOne();
            }
            InitIntance(2, value);
        }

        static void TestMultiThreads()
        {
            Thread t1 = new(() =>
            {
                ThreadBodyOne("ABOBA");
            });
            Thread t2 = new(() =>
            {
                ThreadBodyTwo("AMOGUS");
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }

        static void TestMainThread()
        {
            Singletone s1 = Singletone.GetInstance("BEAR");
            Singletone s2 = Singletone.GetInstance("VODKA");

            if (ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Singletone works; s1 and s2 have same instance.");
            }
            else
            {
                Console.WriteLine("Singletone failed; s1 and s2 have another instance");
            }

            Console.WriteLine($"MainThread(s1): Hash={s1.GetHashCode()} | Value={s1.Value}");
            Console.WriteLine($"MainThread(s2): Hash={s2.GetHashCode()} | Value={s2.Value}");
        }

        [MTAThread]
        static void Main()
        {
            TestMultiThreads();
            TestMainThread();
            _ = Console.ReadKey(true);
        }
    }
}

