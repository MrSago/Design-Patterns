using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class Shape
    {
        public double X, Y;
        public string color;
        public Shape(double _X, double _Y, string _color)
        {
            X = _X;
            Y = _Y;
            color = _color;
        }
        public abstract Shape clone();
    }
}
