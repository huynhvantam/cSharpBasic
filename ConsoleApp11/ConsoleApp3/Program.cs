using System;
using System.Collections.Generic;
using System.IO;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "Text22.txt";
            Console.WriteLine("how many ?");
            var number = int.Parse(Console.ReadLine());
            var numberList = new List<int>();
            WriteTF(filePath, number);
            ReadTF(filePath, numberList);

        #region
        Menu:
            switch (Menu())
            {
                case 1:
                    FindMinMax(numberList, true);
                    goto Menu;
                case 2:
                    FindMinMax(numberList, false);
                    goto Menu;
                case 3:
                    Sum(numberList);
                    goto Menu;
                case 4:
                    Sort(numberList, filePath);
                    goto Menu;
                case 5:
                    Search(numberList);
                    goto Menu;
                case 6:
                    break;
            }
            #endregion
        }
        #region
        private static int Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Find Min");
            Console.WriteLine("2.Find Max");
            Console.WriteLine("3.Find Sum");
            Console.WriteLine("4.Sort");
            Console.WriteLine("5.Search");
            Console.WriteLine("6.Exit");
            return int.Parse(Console.ReadLine());
        }
        #endregion
        #region
        private static void Search(List<int> list)
        {
            Console.WriteLine("search for what number ?");
            int target = int.Parse(Console.ReadLine());
            bool count = false;
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    Console.WriteLine($"{target}found at {i}");
                    count = true;
                }
            }
            if (count == false)
            {
                Console.WriteLine("no number");
            }
        }
        #endregion
        #region
        private static void Sort(List<int> list, string path)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            var sw = new StreamWriter(path, false);
            for (int i = 0; i < list.Count; i++)
            {
                sw.Write(list[i] + "-");
            }
            sw.Close();
        }
        #endregion
        #region
        private static void Sum(List<int> list)
        {
            int Sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Sum += list[i];
            }
            Console.WriteLine($"Sum: {Sum}");
        }
        private static void FindMinMax(List<int> list, bool Case)
        {
            var min = list[1];
            var max = list[list.Count - 1];
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            if (Case)
            {
                Console.WriteLine($"min: {min}");
            }
            if (!Case)
            {
                Console.WriteLine($"max: {max}");
            }
        }
        #endregion
        private static void ReadTF(string filePath, List<int> list)
        {
            StreamReader sr = new StreamReader(filePath);
            Console.WriteLine($"do dai cua mang : {sr.ReadLine()}");
            string number = sr.ReadLine();

            string[] NumberStringSPlit = number.Split("-");
            for (var i = 0; i < NumberStringSPlit.Length; i++)
            {
                list.Add(int.Parse(NumberStringSPlit[i].Trim()));
            }
            sr.Close();
        }
        private static void WriteTF(string filePath, int number)
        {
            Random random = new Random();
            var sw = new StreamWriter(filePath, false);
            sw.WriteLine(number);
            for (var i = 0; i < number; i++)
            {
                sw.Write(random.Next(1, 100) + "-");
                if (i == number - 1)
                {
                    sw.Write(random.Next(1, 100));
                }
            }
            sw.Close();
        }
    }
}