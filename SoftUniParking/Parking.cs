using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;

        public int Count => this.cars.Count;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new Dictionary<string, Car>();
        }

        public string AddCar(Car car)
        {
            if (this.cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.cars.Count() == capacity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";


        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.ContainsKey(registrationNumber))
            {
                this.cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";

            }

            return "Car with that registration number, doesn't exist!";

        }

        public Car GetCar(string registrationNumber)
        {
            return this.cars[registrationNumber];
        }


        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                Console.WriteLine(RemoveCar(number));
            }
        }
    }
}
