using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Rectangle : Shape
    {
        public double Width, Height;
        public Rectangle(double _x, double _y, string _color, double _width, double _height) :
            base(_x, _y, _color)
        {
            Width = _width;
            Height = _height;
        }
        public override Shape clone()
        {
            return (Rectangle)MemberwiseClone();
        }
    }
    class Circle : Shape
    {
        public double radius;
        public Circle(double _x, double _y, string _color, double _radius) :
            base(_x, _y, _color)
        {
            radius = _radius;
        }
        public override Shape clone()
        {
            return (Circle)MemberwiseClone();
        }
    }
}
