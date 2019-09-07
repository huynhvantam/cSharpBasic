using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Rectangle : Shape
    {
        protected double side1, side2;

        public int Side1 { get; internal set; }
        public int Side2 { get; internal set; }
    }
}
