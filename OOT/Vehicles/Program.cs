using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        private static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Cho phep nhap Bike");
            Console.WriteLine("2-Show list Bike");
            Console.WriteLine("3-Cho phep nhap Car");
            Console.WriteLine("4-Show list Car");
            Console.WriteLine("5-Thoat");
        }
        static void Main(string[] args)
        {
            int input;
            List<Bike> bikelist = new List<Bike>();
            List<Car> carlist = new List<Car>();
            do
            {
                Menu();
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("Nhap so bike");
                        int n = Int32.Parse(Console.ReadLine());
                        Bike bike1;
                        for (int i = 0; i < n; i++)
                        {
                            bike1 = new Bike();
                            Console.Write("Speed: ");
                            bike1.Speed = Int32.Parse(Console.ReadLine());
                            Console.Write("Make: ");
                            bike1.Make = Console.ReadLine();
                            Console.Write("Model: ");
                            bike1.Model = Console.ReadLine();
                            Console.Write("Year: ");
                            bike1.Year = Console.ReadLine();
                            bikelist.Add(bike1);
                        }
                        break;
                    case 2:
                        foreach (var vehicle in bikelist)
                        {
                            Console.WriteLine(vehicle.ToString());
                        }
                      
                        break;


                    case 3:
                        Console.Write("Nhap so Car: ");
                        int m = Int32.Parse(Console.ReadLine());
                        Car car1;
                        for (int i = 0; i < m; i++)
                        {
                            car1 = new Car();
                            Console.Write("Speed: ");
                            car1.Speed = Int32.Parse(Console.ReadLine());
                            Console.Write("Make: ");
                            car1.Make = Console.ReadLine();
                            Console.Write("Model: ");
                            car1.Model = Console.ReadLine();
                            Console.Write("Year: ");
                            car1.Year = Console.ReadLine();
                            carlist.Add(car1);
                        }

                        break;
                    case 4:
                        foreach (var car in carlist)
                        {
                            Console.WriteLine(car.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        break;
                }
            }
            while (input != 5);

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