using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                start: Console.WriteLine("Menu");
                Console.WriteLine("1-Create new circle");
                Console.WriteLine("2-Create new Square");
                Console.WriteLine("3-Create new Rectangle");
                Console.WriteLine("4-Out");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("1-Create new circle 1");
                        var circle = new Circle();
                        Console.Write("Enter radius ");
                        circle.Radius = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Area of circle :{circle.Area()}");
                        Console.WriteLine($"Perimeter of circle :{circle.Perimeter()}");
                        Console.WriteLine("==========");
                        goto start;

                        break;
                    case 2:
                        Console.WriteLine("2-Create new Square");
                        var square = new Square();

                        Console.Write("Enter 1 canh ");
                        square.Side1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Area of square :{square.Area()}");
                        Console.WriteLine($"Perimeter of square :{square.Perimeter()}");
                        Console.WriteLine("==========");
                        goto start;
                        break;
                    case 3:
                        Console.WriteLine("3-Create new Rectangle");
                        var rectangle = new Reactangle();

                        Console.Write("Enter width ");
                        rectangle.Slide1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Height ");
                        rectangle.Slide2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Area of rectangle :{rectangle.Area()}");
                        Console.WriteLine($"Perimeter of rectangle :{rectangle.Perimeter()}");
                        Console.WriteLine("==========");
                        goto start;
                        break;
                    case 4:
                        Console.WriteLine("Out !");
                        break;
                    default:
                        Console.WriteLine("Wrong !");
                        goto start;
                        break;
                }

            } while (input > 4);





        }
    }
}
