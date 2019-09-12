using System;

namespace ontap
{
    class Program
    {
        static void Main()
        {
            //int a = 21;
            //int b = 5;
            //double c = (double)a / (double)b;
            //Console.WriteLine(c);
            //int a1 = 15;
            //string b1 = a1.ToString();
            //Console.WriteLine(b1);
            //    bool check;
            //    int test;
            //    menu();
            //    Console.WriteLine("nhap so di");
            //    check = int.TryParse(Console.ReadLine(), out test);
            //    while (!check || test < 1)
            //    {
            //        Console.WriteLine("nhap ngu - chon lai menu ");
            //        menu();
            //        check = int.TryParse(Console.ReadLine(), out test);
            //    }
            //    Console.WriteLine(test);

            //}
            //static void menu()
            //{
            //    Console.WriteLine("1");
            //    Console.WriteLine("2");
            //    Console.WriteLine("3");

            //}
            //Number num = new Number();
            //Console.WriteLine(num.number);
            SwitchNumber num = new SwitchNumber();
            num.Print();
            NumberClass nu = new NumberClass();

        }
        class NumberClass
        {
            protected int number = 10;
        }
        class SwitchNumber : NumberClass
        {
            public void Print()
            {
                Console.WriteLine(number);
            }
        }
    }
}
