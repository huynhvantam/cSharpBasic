using System;

namespace pa3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            dowhile();
        }
        static void forr()
        {
            int sum = 1;
            int num = 0;
            Console.WriteLine("Enter a number");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                forr();
                return;
            }
            for (int i = 1; i <= num; i++)
            {
                sum *= i;

            }
            Console.WriteLine($"giai thua cua {num} la {sum}");
        }
        static void whilee()
        {
            int sum = 1;
            int num = 0;
            Console.WriteLine("Enter a number");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                whilee();
                return;
            }
            int i = 1;
            while (i <= num)
            {
                sum *= i;
                i++;
            }
            Console.WriteLine($"giai thua cua {num} la {sum}");
        }
        static void dowhile()
        {
            int sum = 1;
            int num = 0;
            Console.WriteLine("Enter a number");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                dowhile();
                return;
            }
            int i = 1;
            do
            {
                sum *= i;
                i++;
            }
            while (i <= num);


            Console.WriteLine($"giai thua cua {num} la {sum}");
        }
    }
}
