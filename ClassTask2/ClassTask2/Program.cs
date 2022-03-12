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
            int fuelCapacity = 40;
            double fuelFor1Km = 0.5;
            int currentFuel = 6;
            int km = 10000;

            Car car = new Car(model, brand, year, fuelCapacity, fuelFor1Km, color, currentFuel);
            car.ShowInfo();

            double result = car.Drive(km);
            car.PrintCurrentFuel(result);
        }
    }
}
