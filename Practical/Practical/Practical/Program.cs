using System;

namespace pa3
{
    class Program
    {
        static void Main()
        {
            Menu();

        }
        static void car()
        {
            Console.WriteLine("this is a car");
        }
        static void bike()
        {
            Console.WriteLine("this is a bike");
        }
        static void Menu()
        {
            int pick;
            do
            {

                Console.WriteLine("1__Add a list car.");
                Console.WriteLine("2__Add a list bike.");
                Console.WriteLine("3__ EXIT");
                int.TryParse(Console.ReadLine(), out pick);
                Console.WriteLine("-------------------");

            }
            while (pick < 1 || pick > 3);
            switchcase(pick);
        }

        static void switchcase(int a)
        {
            switch (a)
            {
                case 1:
                    car();
                    break;
                case 2:
                    bike();
                    break;
                case 3:
                    break;
            }
        }
    }
}
