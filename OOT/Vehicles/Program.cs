using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {


        //private static int input;

        static void Main(string[] args)
        {
            int input;
            do
            {

            start: Console.WriteLine("Menu");
                Console.WriteLine("1-Cho phep nhap Bike");
                Console.WriteLine("2-Show list Bike");
                Console.WriteLine("3-Cho phep nhap Car");
                Console.WriteLine("4-Show list Car");
                Console.WriteLine("5-Thoat");
                input = Convert.ToInt32(Console.ReadLine());
                List<Bike> bikelist = new List<Bike>();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("==========");
                        Console.WriteLine("1-Cho phep nhap Bike");
                        Console.Write("Nhap bike");
                        Console.WriteLine("nhap make di:");


                        Console.WriteLine($"Bike Make:{bike1.Make}");
                        Console.WriteLine("==========");
                        for (var i = 0; i < 3; i++)
                        {
                            Bike bike2 = new Bike();

                            bikelist.Add(bike2);
                        }

                        foreach (var item in bikelist)
                        {

                        }
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

////Console.WriteLine("Hello World!");
////Vehicle bike1 = new Vehicle();
////Console.WriteLine(bike1.ToString());
//int input;
//do
//{
//start: Console.WriteLine("Menu");
//    Console.WriteLine("1-Cho phep nhap Bike");
//    Console.WriteLine("2-Show list Bike");
//    Console.WriteLine("3-Cho phep nhap Car");
//    Console.WriteLine("4-Show list Car");
//    Console.WriteLine("5-Thoat");
//    input = Convert.ToInt32(Console.ReadLine());

//    switch (input)
//    {
//        case 1:
//            Console.WriteLine("1-Cho phep nhap Bike");
//            //var circle = new Circle();
//            Bike bike1 = new Bike();
//            Console.Write("Nhap bike");
//            //circle.Radius = Convert.ToInt32(Console.ReadLine());
//            bike1.
//            Console.WriteLine($"Area of circle :{circle.Area()}");
//            Console.WriteLine($"Perimeter of circle :{circle.Perimeter()}");
//            Console.WriteLine("==========");
//            goto start;

//            break;
//        case 2:
//            Console.WriteLine("2-Create new Square");
//            var square = new Square();

//            Console.Write("Enter 1 canh ");
//            square.Side1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine($"Area of square :{square.Area()}");
//            Console.WriteLine($"Perimeter of square :{square.Perimeter()}");
//            Console.WriteLine("==========");
//            goto start;
//            break;
//        case 3:
//            Console.WriteLine("3-Create new Rectangle");
//            var rectangle = new Reactangle();

//            Console.Write("Enter width ");
//            rectangle.Slide1 = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter Height ");
//            rectangle.Slide2 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine($"Area of rectangle :{rectangle.Area()}");
//            Console.WriteLine($"Perimeter of rectangle :{rectangle.Perimeter()}");
//            Console.WriteLine("==========");
//            goto start;
//            break;
//        case 4:
//            Console.WriteLine("Out !");
//            break;
//        default:
//            Console.WriteLine("Wrong !");
//            goto start;
//            break;
//    }

//} while (input > 4);