using System;
using System.Collections.Generic;
using Prototype;

List<Shape> sourceList = [];

Circle circle1 = new(1.0, 1.0, "blue", 4.0);
sourceList.Add(circle1);

Circle circle2 = (Circle)circle1.Clone();
sourceList.Add(circle2);

Rectangle rectangle1 = new(2.2, 2.2, "red", 5.5, 6.6);
sourceList.Add(rectangle1);

Rectangle rectangle2 = (Rectangle)rectangle1.Clone();
sourceList.Add(rectangle2);

foreach (var it in sourceList)
{
    Console.WriteLine(it.GetInfo());
}
