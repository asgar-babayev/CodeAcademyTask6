using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Vehicle
    {
        public int year;
        public string color;

        public Vehicle(int year)
        {
            this.year = year;
        }
        public Vehicle(string color, int year) : this(year)
        {
            this.color = color;
        }
    }
}
