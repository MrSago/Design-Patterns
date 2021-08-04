
using System;

namespace Adapter
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            RoundHole hole = new(5.0);
            RoundPeg rpeg = new(5.0);
            Console.WriteLine($"{hole.Fits(rpeg)}"); // True

            SquarePeg small_sqpeg = new(5.0);
            SquarePeg large_sqpeg = new(10.0);
            //Console.WriteLine($"{hole.Fits(small_sqpeg)}"); // compile error

            SquarePegAdapter small_sqpeg_adapter = new(small_sqpeg);
            SquarePegAdapter large_sqpeg_adapter = new(large_sqpeg);
            Console.WriteLine($"{hole.Fits(small_sqpeg_adapter)}"); // True
            Console.WriteLine($"{hole.Fits(large_sqpeg_adapter)}"); // False

            Console.ReadKey(true);
        }
    }
}

