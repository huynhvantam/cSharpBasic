using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static int[] arr = new int[4] { 3, 7, 5, 11 };
        static void Main()
        {
            var filePath = "Text1.txt";
            Menu();

        }
        static void Sum()
        {
            Console.WriteLine($"Max cua arr: {arr.Max()}");
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"Sum cua arr: {sum}");
        }
        static void Min()
        {
            Console.WriteLine($"Min cua arr: {arr.Min()}");
        }
        static void Max()
        {
            Console.WriteLine($"Max cua arr: {arr.Max()}");
        }
        static void Search()
        {
            Console.WriteLine("nhap gia tri can tim");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (num == arr[i])
                {
                    Console.WriteLine($"gia tri {num} nam o index {i}");
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("khong tim thay");
            }
        }
        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Max");
            Console.WriteLine("2-Min");
            Console.WriteLine("3-Tong");
            Console.WriteLine("4-Sort");
            Console.WriteLine("5-Search");
            Console.WriteLine("6-Exit");
            bool check = true;
            int pick;
            check = int.TryParse(Console.ReadLine(), out pick);
            while (!check || pick < 1 || pick > 6)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("nhap sai, nhap lai di");
                Menu();
                check = int.TryParse(Console.ReadLine(), out pick);
            }
            switch (pick)
            {
                case 1:
                    Max();
                    Menu();
                    break;
                case 2:
                    Min();
                    Menu();
                    break;
                case 3:
                    Sum();
                    Menu();
                    break;
                case 4:
                    Sum();
                    Menu();
                    break;
                case 5:
                    Search();
                    Menu();
                    break;
                case 6:
                    break;
            }
        }
    }
}