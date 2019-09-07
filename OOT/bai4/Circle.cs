using System;

namespace Shapes
{
    class Circle : Shape
    {
        protected double radius;

        public double Radius { get => radius; set => radius = value; }

        public double Area()
        {
            return radius * radius * Math.PI;
        }

        public double Perimeter()
        {
            return 2 * radius * Math.PI;
        }

    }
}
