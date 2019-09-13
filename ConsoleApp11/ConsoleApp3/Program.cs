using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static int[] arr = new int[4] { 3, 7, 5, 11 };
        static void Main()
        {
            Menu();
            Min();
            Max();
            Sum();
            Search();

            //chieudaiMang();
            //mang2chieu();
            //mang1chieu();
            //freetut();
            //mangmang();
            //baitapmang1chieu();
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
        }

    }
}
//static void chieudaiMang()
//{
//    int[] arr = new int[5];
//    int len = arr.Length;
//    Console.WriteLine($"do dai cua mang {len}");
//    long longLength = arr.LongLength;
//    Console.WriteLine("DO LON CUA DO DAI MA TRAN  : {0}", longLength);
//    int[,] arr2 = new int[2, 10];
//    Console.WriteLine($"sophan tu cua ma tran 2 chieu {arr2.Length}");

//}
//static void mang2chieu()
//{
//    int[][] Arr = new int[3][];
//    Arr[0] = new int[] { 10, 20, 30 };
//    Arr[1] = new int[] { 40, 50, 60, 70 };
//    Arr[2] = new int[] { 80, 90, 100, 110, 120 };
//    //for (int i = 0; i < Arr.Length; i++)
//    //{
//    //    for (int j = 0; j < Arr.Length; j++)
//    //    {
//    //        Console.WriteLine(Arr[i][j]);
//    //    }
//    //}
//    int[,] numbers = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
//    foreach (int i in numbers)
//    {
//        Console.Write(i);
//    }
//}
//static void mang1chieu()
//{
//    int[] arr = new int[5] { 1, 2, 3, 4, 5 };
//    string[] arr1 = new string[2] { "haha", "hhehe" };
//    int[] arr2 = { 1, 2, 3, 43, 54 };
//    string[] arr3 = { "hoho", "haha" };
//    int len = arr.Length;
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}
//static void freetut()
//{
//    int[] arr = new int[5]; //tạo mảng
//    arr[0] = 5;  // khỏi tạo giá trị cho phần tử thứ nhất
//    arr[2] = 10;
//    arr[4] = 3;

//    // Duyệt qua từng phần tử mảng
//    //for (int i = 0; i < arr.Length; i++)
//    //{
//    //    Console.WriteLine("Gia tri phan tu thu " + (i + 1) + " = " + arr[i]);
//    //}
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }

//    Console.WriteLine("00000000000000000000000000000000000");
//    int[,] arr1 = new int[3, 3];
//    arr1[0, 1] = 2;
//    arr1[1, 2] = 3;
//    arr1[2, 0] = 4;
//    //foreach (var item in arr1)
//    //{
//    //    Console.WriteLine($"phan tu thu la {item}");
//    //}
//    for (int i = 0; i < 3; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            Console.WriteLine($"phan tu thu [{i}][{j}] la {arr1[i, j]}");
//            Console.WriteLine();
//        }
//    }

//    Console.ReadKey();
//}
//static void mangmang()
//{
//    int[][] arr = new int[3][];
//    arr[0] = new int[] { 1, 2, 3 };
//    arr[1] = new int[3] { 4, 5, 6 };
//    arr[2] = new int[1];
//    int[][] arr1 = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[3] };
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.WriteLine($"gia tri phan tu ");
//        for (int j = 0; j < arr.Length; j++)
//        {
//            //Console.WriteLine($"index [{i}][{j}] = {arr[i][j]} ");
//            Console.WriteLine($"");
//        }

//    }

//    int[] arr2 = new int[3]; //tạo mảng
//    arr2[0] = 5;  // khỏi tạo giá trị cho phần tử thứ nhất
//    arr2[1] = 10;
//    arr2[2] = 3;
//    int maxValue = arr2.Max();
//    Console.WriteLine($"gia tri phan tu max{arr2.Max()}");
//    Console.WriteLine($"gia tri phan tu min {arr2.Min()}");

//}