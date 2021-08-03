
using System;
using System.Threading;

namespace Singletone
{
    static class AppMain
    {
        static void ThreadBody(int _threadNum, string _value)
        {
            Singletone singletone = Singletone.GetInstance(_value);
            Console.WriteLine($"Thread{_threadNum}: Hash={singletone.GetHashCode()} | Value={singletone.Value}");
        }
        static void TestMultiThreads()
        {
            Thread t1 = new(() =>
            {
                ThreadBody(1, "ABOBA");
            });
            Thread t2 = new(() =>
            {
                ThreadBody(2, "AMOGUS");
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
        static void Main(string[] args)
        {
            TestMultiThreads();
            TestMainThread();
            Console.ReadKey(true);
        }
    }
}

