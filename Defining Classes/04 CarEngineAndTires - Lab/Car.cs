using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;


        public Car()
        {
            
            this.make = "VW";
            this.Model = "Golf";
            this.year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year) :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption):this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine, Tire[] tires): this(make,model,year,fuelQuantity,fuelConsumption)
        {
            this.Engine = engine;
            this.tires = tires;

        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set => fuelQuantity = value;
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set => fuelConsumption = value;
        }
        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public IReadOnlyCollection<Tire> Tires
        {
            get
            {
                return this.tires;
            }

            private set
            {

            }
        }


        public void Drive(double distance)
        {
            if (this.FuelQuantity-distance*FuelConsumption>0)
            {
                this.FuelQuantity -=  distance*this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }


    }
}
