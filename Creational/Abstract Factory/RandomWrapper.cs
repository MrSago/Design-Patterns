using System;

namespace Abstract_Factory;

public static class RandomWrapper
{
    private static readonly int seed = Environment.TickCount;
    private static readonly Random random = new(seed);
    public static Random Random => random;
}
