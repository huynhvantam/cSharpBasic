using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
    class Shop
    {
        private static List<Produck> ProductList = new List<Produck>();
        public void AddProduct()
        {
            Console.WriteLine("AddProduct");
            Produck produck = new Produck();
            Console.Write("Enter name of product: ");
            produck.Name = Console.ReadLine();

            bool check = false;
            double pricee = 0;
            while (!check || pricee < 1 || pricee > 100)
            {
                Console.Write("Enter name of Price: ");
                check = double.TryParse(Console.ReadLine(), out pricee);
            }
            produck.Price = pricee;

            Console.Write("Enter name of Description: ");
            produck.Description = Console.ReadLine();
            ProductList.Add(produck);
        }
        //public void RemoveProduct()
        //{
        //    Console.WriteLine("2.Remove product\n");
        //    string name = Console.ReadLine();
        //    int check = 0;
        //    foreach (var item in ProductList)
        //    {

        //        if (string.Compare(item.Name, name) == 0)
        //        {
        //            ProductList.Remove(item);
        //            check++;
        //            Console.WriteLine("success");
        //            break;
        //        }
        //    }

        //    if (check == 0)
        //    {
        //        Console.WriteLine("Product doesn't exist\n");
        //    }
        public void RemoveProduct()
        {
            int check;
            Console.WriteLine("RemoveProduct");
        }
        public void IterateProductList()
        {
            Console.WriteLine("IterateProductList");

            foreach (var produck in ProductList)
            {

                produck.ViewInfor();
            }
            Console.WriteLine("---------------------------\n");
        }
        public void SearchProduct()
        {
            Console.WriteLine("SearchProduct");
            string seachName = Console.ReadLine();

            foreach (var produck in ProductList)
            {
                if (produck.Name == seachName)
                {
                    produck.ViewInfor();

                }
                else
                {
                    Console.WriteLine("khong ton tai");
                }
            }
        }
    }
}