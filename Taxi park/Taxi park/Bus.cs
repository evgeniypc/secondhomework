using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{
    class Bus : Gasсar, IPassenger
    {
        private int passengers = 0;

        public Bus(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration,
            int seatsNumber, bool automaticTransmission, bool airConditioning, string fuelType, int fuelTankCapacity, int fuelEconomy)
            : base(manufacturer, type, model, price, year, maxSpeed, mileage, acceleration, seatsNumber, automaticTransmission, airConditioning, fuelType, fuelTankCapacity, fuelEconomy)
        {
        }

        public int AddPassenger()
        {
            Console.WriteLine("One more passenger joined");
            passengers++;
            return passengers;
        }

        public int GetPassengerCount()
        {
            return passengers;
        }
    }
}
