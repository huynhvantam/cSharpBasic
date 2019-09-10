using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        private string type;
        private double speed;
        public int Wheel { get; set; }


        public string Type { get => type; set => type = value; }
        public double Speed { get => speed; set => speed = value; }
        public Car()
        {
            Wheel = 4;

        }
        public Car(string make, string model, string year, string type, double speed) : base(make, model, year)
        {
            Speed = speed;
            Type = type;

        }
        public override string ToString()
        {
            return "ID" + Id + "      Car Speed:" + Speed + "    Car Make:" + Make + "    Car Model:" + Model + "    Car Year:" + Year + "    Bike Wheet:" + Wheel;
        }
    }
}
