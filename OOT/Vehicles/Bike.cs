using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bike : Vehicle
    {
        private string type;
        private double speed;
        private string wheel;

        public string Type { get => type; set => type = value; }
        public double Speed { get => speed; set => speed = value; }
        public Bike()
        {

        }
        public Bike(string make, string model, string year,string type, double speed):base (make,model,year)
        {
            Speed = speed;
            Type = type;

        }
        public override string ToString()
        {
            return "Bike Speed:" + Speed + "    Bike Make:" + Make + "    Bike Model:" + Model + "    Bike Year:" + Year;
        }

    }
}
