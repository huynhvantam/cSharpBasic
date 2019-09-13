using System;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteToFile("text.txt");
        }

        private static void WriteToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Random random = new Random();
            sw.WriteLine("aaaaaaaaaaa");
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(random.Next(1, 100));
            }
            sw.Close();
        }
    }
}
