
using System;
using System.Threading;

namespace Singletone
{
    static class AppMain
    {
        static bool done = false;
        static readonly EventWaitHandle ewh = new(false, EventResetMode.AutoReset);

        static void InitIntance(int _thNum, string _value)
        {
            Singletone singletone = Singletone.GetInstance(_value);
            Console.WriteLine($"Thread{_thNum}: Hash={singletone.GetHashCode()} | Value={singletone.Value}");
        }

        static void ThreadBodyOne(string _value)
        {
            InitIntance(1, _value);
            done = true;
            ewh.Set();
        }

        static void ThreadBodyTwo(string _value)
        {
            while (!done)
            {
                ewh.WaitOne();
            }
            InitIntance(2, _value);
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
        static void Main(string[] args)
        {
            TestMultiThreads();
            TestMainThread();
            Console.ReadKey(true);
        }
    }
}

