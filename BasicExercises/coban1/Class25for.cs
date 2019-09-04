using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class25for
    {
        public static void Main()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (var i =0; i < 100; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
