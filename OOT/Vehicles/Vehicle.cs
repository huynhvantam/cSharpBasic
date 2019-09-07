using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Vehicle
    {
        private int id;
        //private static int idTemp = 1;

        private string make;
        private string model;
        private string year;
        //public Vehicle()
        //{
        //    id = idTemp++;
        //}

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }
        


        //public int ID { get => id; }


        //public string Make
        //{
        //    set { make = value; }
        //    get { return make; }
        //}

        //public string Model
        //{
        //    set { model = value; }
        //    get { return model; }
        //}

        //public string Year
        //{
        //    set { year = value; }
        //    get { return year; }
        //}


        public Vehicle()
        {
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
