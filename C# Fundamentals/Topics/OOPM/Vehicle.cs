using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }

        public  void Run();


        public void ShowDetails();
    }

    class Car : IVehicle
    {

        

        public string FuelType { get; set; }
        public int SittingCapacity { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }


        static public int noOfTires = 3;

        
       

        public Car(string make, string model, int year, int speed, string fuelType, int sittingCapacity)
        {
            FuelType = fuelType;
            SittingCapacity = sittingCapacity;
            Make = make;
            Model = model;
            Year = year;
            Speed = speed;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Fuel Type: {FuelType} Sitting Capacity: {SittingCapacity}");
            Console.WriteLine(this.Make);
        }

        
        public  void Run()
        {
            Console.WriteLine("Ruuning at speed of " + Speed);

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
