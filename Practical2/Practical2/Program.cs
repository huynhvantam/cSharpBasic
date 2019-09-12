using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("1.Add new product");
            Console.WriteLine("2.Remove product");
            Console.WriteLine("3.Iterate product list");
            Console.WriteLine("4.Search product");
            Console.WriteLine("5.Exit");
            Console.Write("> ");
        }
        static void Main()
        {
            Menu();
            bool check;
            int pick;
            check = int.TryParse(Console.ReadLine(), out pick);
            while (!check || pick < 1 || pick > 5)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("nhap sai, nhap lai di");
                Menu();
                check = int.TryParse(Console.ReadLine(), out pick);
            }
            Shop shop = new Shop();
            switch (pick)
            {
                case 1:
                    shop.AddProduct();
                    Main();
                    break;
                case 2:
                    shop.RemoveProduct();
                    Main();
                    break;
                case 3:
                    shop.IterateProductList();
                    Main();
                    break;
                case 4:
                    shop.SearchProduct();
                    Main();
                    break;
                case 5:

                    break;
            }

        }

    }

}
