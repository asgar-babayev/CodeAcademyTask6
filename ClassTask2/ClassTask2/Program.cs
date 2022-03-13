using System;
using ClassTask2.Models;

namespace ClassTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model = "BMW";
            string brand = "M5";
            string color = "Mavi";
            int year = 2010;
            int fuelCapacity = 5;
            double fuelFor1Km = 0.5;
            double currentFuel = 3.5;
            int km = 10;

            Car car = new Car(model, brand, year, fuelCapacity, fuelFor1Km, color, currentFuel);
            car.ShowInfo();

            car.Drive(km);
        }
    }
}
