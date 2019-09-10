using System;

namespace pa5
{
    class Program
    {
        static void Main(string[] args)
        {
            teamm();
        }
        static void teamm()
        {
            //int pick;
            //Console.WriteLine("team football");
            //int.TryParse(Console.ReadLine(), out pick);
            //Console.WriteLine($"pick {pick} team football");
            bool choosen;
            int check;
            string name;
            Console.WriteLine("team football");
            choosen = int.TryParse(Console.ReadLine(), out check);

            while (!choosen || check < 1)
            {
                Console.WriteLine("nhap ngu");

                choosen = int.TryParse(Console.ReadLine(), out check);

            }
            for (var i = 1; i <= check; i++)
            {
                Console.WriteLine("nhap team");
                name = Console.ReadLine();
                Console.WriteLine($"Team {i}: {name}");
            }
        }
    }
}