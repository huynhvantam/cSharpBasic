using System;
using System.IO;
using System.Collections;

namespace ConsoleApp11
{
    class Program

    {
        // mang 2 chieu  n, m 
        // 2 hang 3 cot 5 6 8        0 3 9 
        // min cua mang
        // max cuamang
        // sap xep tang dan
        // tim kiem phan tu mang
        // tong cua mang
        //lam cai menu 12345 cac muc
        // 

        // oop product , animal 
        // bo sung them muc ghi file
        // tim kiem , edit thi tien hanh ghi lai file do

        static void Main(string[] args)
        {
            WriteToFile("text.txt");
        }

        private static void WriteToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Random random = new Random();
            sw.WriteLine("do dai");
            ArrayList arrPersons = new ArrayList();
            arrPersons.Add("Nguyen Van A");
            arrPersons.Add("Nguyen Van b");
            arrPersons.Add("Nguyen Van C");

            sw.WriteLine(arrPersons[0]);
            sw.WriteLine(arrPersons[1]);
            sw.WriteLine(arrPersons[2]);
            //foreach (var i in arrPersons)
            //{
            //    sw.WriteLine(arrPersons[i]);
            //}
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(random.Next(1, 100));
            }

            sw.Close();

        }

    }
}
