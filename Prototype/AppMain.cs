using System;
using System.Collections.Generic;

namespace Prototype
{
    static class AppMain
    {
        static void PrintShapeInfo(Shape shape)
        {
            if (shape is Circle circle)
            {
                Console.WriteLine($"It's circle: Radius={circle.radius}");
            }
            else if (shape is Rectangle rectangle)
            {
                Console.WriteLine($"It's rectangle: Width={rectangle.Width}, Heigth={rectangle.Height}");
            }
            Console.WriteLine($"X={shape.X}, Y={shape.Y}, color={shape.color}\n");
        }

        static void Main(string[] args)
        {
            List<Shape> sourceList = new();

            Circle circle1 = new(1.0, 1.0, "blue", 4.0);
            sourceList.Add(circle1);

            Circle circle2 = (Circle)circle1.clone();
            sourceList.Add(circle2);

            Rectangle rectangle1 = new(2.2, 2.2, "red", 5.5, 6.6);
            sourceList.Add(rectangle1);

            Rectangle rectangle2 = (Rectangle)rectangle1.clone();
            sourceList.Add(rectangle2);

            foreach (var it in sourceList)
            {
                PrintShapeInfo(it);
            }

            Console.ReadKey(true);
        }
    }
}
