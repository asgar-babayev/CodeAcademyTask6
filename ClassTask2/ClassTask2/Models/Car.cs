using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask2.Models
{
    class Car : Vehicle
    {
        public string brand;
        public string model;
        public double fuelCapacity;
        public double fuelFor1Km;
        public double currentFuel;

        public Car(string model, string brand, int year, double fuelCapacity, double fuelFor1Km) : base(year)
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        public Car(string model, string brand, int year, double fuelCapacity, double fuelFor1Km, string color) : base(color, year)
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        public Car(string model, string brand, int year, double fuelCapacity, double fuelFor1Km, string color, double currentFuel) : this(model, brand, year, fuelCapacity, fuelFor1Km, color)
        {
            this.currentFuel = currentFuel;
        }
        public Car(string model, string brand, int year, double fuelCapacity, double fuelFor1Km,  double currentFuel): this(model, brand, year, fuelCapacity,fuelFor1Km)
        {
            this.currentFuel = currentFuel;
        }

        public void ShowInfo()
        {
            Console.WriteLine($@"Model: {model}
Brand: {brand}
Rəng: {color}
İl: {year}
Yanacaq tutumu: {fuelCapacity} l
1km-də yanan yanacaq: {fuelFor1Km} l
Cari yanacaq: {currentFuel} l
--------------------------------------------------");
        }

        public void Drive(double km)
        {
            double current_Fuel = this.currentFuel;
            if (km > 0 && current_Fuel >= 0 && current_Fuel < fuelCapacity)
            {
                current_Fuel = current_Fuel - (km * fuelFor1Km);
                Console.WriteLine($"Gedilən məsafə: {km} km");
                if (current_Fuel > 0)
                {
                    Console.WriteLine($"{current_Fuel} l benzin qalıb");
                }
                else if (current_Fuel == 0)
                {
                    Console.WriteLine($"{km} km məsafəyə benzin tam bitəcək.");
                }
                else if (current_Fuel <= 0)
                {
                    current_Fuel = 0;
                    Console.WriteLine($@"{km} km məsafə üçün kifayət qədər benzin yoxdur.
Yanacaq çəni {fuelCapacity} l tutuma malikdir.");
                    current_Fuel = (km * fuelFor1Km) - currentFuel;
                    double temp = currentFuel + current_Fuel;
                    if (current_Fuel <= fuelCapacity && current_Fuel > 0 && temp <= fuelCapacity)
                        Console.WriteLine($"{current_Fuel} l benzin əlavə edib yola davam edə bilərsiz");
                }
            }
            else
            {
                if(current_Fuel > fuelCapacity)
                {
                    Console.WriteLine("Cari yanacaq maksimum yanacaqdan çox ola bilməz.");
                }
                else if (km <= 0)
                {
                    Console.WriteLine("Gediləcək məsafə 0 və ya mənfi ola bilməz.");
                }
                else if (current_Fuel < 0)
                {
                    Console.WriteLine("Cari yanacaq 0-dan az ola bilməz.");
                }
            }
        }
    }
}
