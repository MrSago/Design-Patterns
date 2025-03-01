using System;
using Adapter;

RoundHole hole = new(5.0);
RoundPeg rpeg = new(5.0);
Console.WriteLine($"{hole.Fits(rpeg)}"); // True

SquarePeg smallSqpeg = new(5.0);
SquarePeg largeSqpeg = new(10.0);

// compile error: Argument 1: cannot convert from 'Adapter.SquarePeg' to 'Adapter.RoundPeg'CS1503
// Console.WriteLine($"{hole.Fits(smallSqpeg)}");

SquarePegAdapter smallSqpegAdapter = new(smallSqpeg);
SquarePegAdapter largeSqpegAdapter = new(largeSqpeg);
Console.WriteLine($"{hole.Fits(smallSqpegAdapter)}"); // True
Console.WriteLine($"{hole.Fits(largeSqpegAdapter)}"); // False
