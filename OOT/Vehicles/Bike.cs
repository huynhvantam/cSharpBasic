using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bike : Vehicle
    {
        private int id = 0;
        private string wheel;
        public int Id { get => id; set => id = value; }
        public string Wheel { get => wheel; set => wheel = value; }
    }
}
