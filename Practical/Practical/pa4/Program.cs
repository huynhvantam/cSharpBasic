using System;

namespace pa4
{
    class Program
    {
        static void Main()
        {
            Menu();

        }
        static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1- pick a car");
            Console.WriteLine("2- pick a bike");
            Console.WriteLine("3- EXIT");
            int pick = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out pick);
                Console.WriteLine("Pick again");
            }
            while (pick < 1 || pick > 3);



        }


    }
}
