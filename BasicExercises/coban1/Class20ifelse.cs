using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class20ifelse
    {
        public static int absolutee(int a,int b)
        {
            return a > b ? (a - b) * 2 : b-a;
        }
        public static void Main()
        {
            Console.WriteLine(absolutee(50, 21));
            Console.WriteLine(absolutee(13, 40));
        }
    }
}
