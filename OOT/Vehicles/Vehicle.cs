using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Vehicle
    {
        private int id;
        public int Id { get => id; }
        private static int idTemp = 1;
        public static int IdTemp { get => idTemp; set => idTemp = value; }

        private string make;
        private string model;
        private string year;
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }
       
        public Vehicle()
        {
            id = idTemp++;
        }
        public Vehicle(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
     public virtual string ToString()
        {
            return Make + Model + Year;
        }



    }
}
