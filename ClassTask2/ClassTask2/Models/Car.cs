using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Car : Vehicle
    {
        public string brand;
        public string model;
        public int fuelCapacity;
        public double fuelFor1Km;
        public int currentFuel;

        public Car(string model, string brand, int year, int fuelCapacity, double fuelFor1Km) : base(year)
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        public Car(string model, string brand, int year, int fuelCapacity, double fuelFor1Km, string color) : base(color, year)
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        public Car(string model, string brand, int year, int fuelCapacity, double fuelFor1Km, string color, int currentFuel) : this(model, brand, year, fuelCapacity, fuelFor1Km, color)
        {
            this.currentFuel = currentFuel;
        }

        public void ShowInfo()
        {
            Console.WriteLine($@"Model: {model}
Brand: {brand}
Rəng: {color}
İl: {year}
Yanacaq tutumu: {fuelCapacity} litr
1km-də yanan yanacaq: {fuelFor1Km} litr
Cari yanacaq: {currentFuel} litr
");
        }

        public double Drive(int km)
        {
            if (km > 0)
                return currentFuel - (km * fuelFor1Km) / 1000;
            return -1;
        }

        public void PrintCurrentFuel(double result)
        {
            if (result > 0)
                Console.WriteLine($"{result} litr benzin qalıb.");
            else if(result == -1)
                Console.WriteLine("Gedilən yol 0 və ya mənfi ədəd ola bilməz.");
            else
                Console.WriteLine("Benzin qalmıyıb");
        }
    }
}
