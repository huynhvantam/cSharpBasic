namespace Shapes
{
    class Reactangle : Shape
    {
        protected double slide1, slide2;

        public double Slide1 { get => slide1; set => slide1 = value; }
        public double Slide2 { get => slide2; set => slide2 = value; }

        public double Area()
        {
            return Slide1 * Slide2;
        }

        public double Perimeter()
        {
            return (Slide1 + Slide2) / 2;
        }

    }
}
