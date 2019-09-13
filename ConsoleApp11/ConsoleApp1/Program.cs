//using System;
//using System.IO;

//namespace ConsoleApp11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteToFile("text1.txt");
//            string textTest = "codeeeeeeeeee";
//            string result = null;
//            result = ReadOnText(textTest);
//            Console.WriteLine(result);
//        }

//        private static string ReadOnText(string textTest)
//        {
//            string result = null;
//            StringReader sr = new StringReader(textTest);
//            string aLine = null;
//            while (true)
//            {
//                aLine = sr.ReadLine();
//                if (aLine != null)
//                {
//                    result = result + aLine;
//                }
//                else
//                {
//                    break;
//                }
//            }

//        }
//        nhap vao 1 so do dai cua mang de ghi vao file
//        private static void WriteToFile(string path)
//        {
//            StringWriter sw = new StringWriter();
//            Random random = new Random();
//            for (int i = 0; i < 4; i++)
//            {
//                sw.WriteLine(random.Next(1, 100));
//            }
//            sw.Close();
//        }
//    }
//}
