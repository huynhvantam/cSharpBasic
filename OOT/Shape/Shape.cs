using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Shape
    {
        protected Location c = new Location();

        public virtual void ToString()
        {
            System.Console.WriteLine();
        }

        public double Area()
        {
            return 0.000;
        }

        public double Perimeter()
        {
            return 0.000;
        }
    }
}
