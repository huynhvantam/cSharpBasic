using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Vehicle
    {
        private string make;
        private string model;
        private string year;
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }

        public Vehicle()
        {
        }
        public Vehicle(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string ToString()
        {
            return "";
        }
    }
}
