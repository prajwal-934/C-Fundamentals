using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }

        public Vehicle(string make, string model, int year, int speed)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = speed;
        }

        public void Run()
        {
            Console.WriteLine("Vehicle is running at speed of " + Speed);
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Vehicle: {Year} {Make} {Model}");
        }
    }

    class Car : Vehicle
    {
        public string FuelType { get; set; }
        public int SittingCapacity { get; set; }

        public Car(string make, string model, int year, int speed, string fuelType, int sittingCapacity) : base(make, model, year, speed)
        {
            FuelType = fuelType;
            SittingCapacity = sittingCapacity;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Fuel Type: {FuelType} Sitting Capacity: {SittingCapacity}");
        }
    }


    class ElectricVehicle : Car
    {
        public string BatteryCapacity { get; set; }

        // Fix: Add a constructor to ElectricVehicle that passes required arguments to the base class constructor  
        public ElectricVehicle(string make, string model, int year, int speed, string fuelType, int sittingCapacity, string batteryCapacity)
            : base(make, model, year, speed, fuelType, sittingCapacity)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Battery Capacity: {BatteryCapacity}");
        }
    }
}
