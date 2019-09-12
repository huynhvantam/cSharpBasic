using System;
using System.Collections.Generic;
using System.Text;

namespace Practical3
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Xây dựng menu chương trình:\n1. Tạo cá sấu\n2. Tạo một con mèo\n3. Tạo một con cá\n4. Xem động vật trên cạn\n5. Xem động vật biển\n6. Xem tất cả động vật\n7. Xóa động vật\n8. Thoát");
        }
        static void Main()
        {
            List<IAnimal> listDV = new List<IAnimal>();
            //List<IMarineAnimal> listM = new List<IMarineAnimal>();
            //List<ITerrestrialAnimal> listT = new List<ITerrestrialAnimal>();

            Console.OutputEncoding = Encoding.UTF8;
            Menu();
            bool check;
            int pick;
            check = int.TryParse(Console.ReadLine(), out pick);
            while (!check || pick < 1 || pick > 8)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("nhap sai, nhap lai di");
                Menu();
                check = int.TryParse(Console.ReadLine(), out pick);
            }
            Cat cat = new Cat();
            Fish fist = new Fish();
            Crocodile cro = new Crocodile();

            switch (pick)
            {
                case 1:
                    Console.WriteLine("de ra ca sau");
                    cro.ID = 5;
                    cro.Name = "XAU XAU";
                    cro.move();
                    listDV.Add(cro);
                    Main();
                    break;
                case 6:
                    Console.WriteLine("DANH SÁCH ĐỘNG VẬT");
                    foreach (var bikes in listDV)
                    {
                        Console.WriteLine(bikes.ToString());
                    }
                    break;
                case 8:

                    break;
            }
        }
        static void switchcase()
        {



        }
    }
    interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }

    }
    interface IMarineAnimal : IAnimal
    {
        void move();
    }
    interface ITerrestrialAnimal : IAnimal
    {
        void move();
    }
    class Cat : ITerrestrialAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void move()
        {
            Console.WriteLine("con Meo di chuyen");
        }

        public override string ToString()
        {
            return $"ID:{ID}      Name: {Name}        Age: {Age}";
        }
    }
    class Fish : IMarineAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void move()
        {
            Console.WriteLine("con ca boi boi");
        }
        public override string ToString()
        {
            return $"ID:{ID}      Name: {Name}        Age: {Age}";
        }
    }
    class Crocodile : IMarineAnimal, ITerrestrialAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void move()
        {
            Console.WriteLine("con ca sau di chuyen");
        }
        public override string ToString()
        {
            return $"ID:{ID}      Name: {Name}        Age: {Age}";
        }
    }

}
