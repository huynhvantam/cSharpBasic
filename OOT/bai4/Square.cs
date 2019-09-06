namespace Shapes
{
    class Square : Shape
    {
        public double Side1 { get; set; }

        public double Area()
        {
            return Side1 * Side1;
        }

        public double Perimeter()
        {
            return Side1 * 4;
        }
    }
}
