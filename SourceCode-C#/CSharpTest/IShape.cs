using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    interface IShape
    {
        double Area();
    }

    class Triangle : IShape
    {
        double IShape.Area() { return 0.0; }
    }

    class Circle : IShape
    {
        double IShape.Area() { return 0.0; }
    }

    class Rectangle : IShape
    {
        double IShape.Area() { return 0.0; }
    }
}
