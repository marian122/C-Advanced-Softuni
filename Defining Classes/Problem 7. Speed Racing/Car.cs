using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.traveledDistance = 0.0;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }
        public void Drive(double distance)
        {
            double fuelNeed = distance * fuelConsumption;

            if (this.fuelAmount < fuelNeed)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
                
            }

            this.fuelAmount -= fuelNeed;
            this.traveledDistance += distance;

        }
    }

}
