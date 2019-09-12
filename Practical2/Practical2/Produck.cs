using System;
using System.Collections.Generic;
using System.Text;

namespace Practical2
{
    class Produck
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] rate { get; set; }
        public void ViewInfor()
        {
            Console.WriteLine($"Name: {Name},        Description:{Description},         Price:{Price}");
        }
    }
}
