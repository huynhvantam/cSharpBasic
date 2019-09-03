using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class22ifelse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput an integerrrr:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(checkc(x));
        }
        //static void Main(string[] args)
        //{
        //    int x;
        //    Console.WriteLine("\nInput an integer:");
        //    x = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(x >= 20 && x <= 100 || x == 200);
        //}
        public static bool checkc(int x)
        {
            if (Math.Abs(x - 100) <= 20 || Math.Abs(x- 200) <= 20)
                return true;
            return false;
        }
        
            
        
    }
}
