
using System;

namespace Abstract_Factory
{
    public static class RandomWrapper
    {
        private static readonly int seed = Environment.TickCount;
        public static Random random = new(seed);
    }
}

