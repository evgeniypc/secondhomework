using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{
    class Gasсar : Car
    {
        public String FuelType { set; get; }
        public int FuelTankCapacity { set; get; }
        public int FuelEconomy { set; get; }

        public Gasсar(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration, int seatsNumber, bool automaticTransmission, bool airConditioning, string fuelType, int fuelTankCapacity, int fuelEconomy)
            : base(manufacturer, type, model, price, year, maxSpeed, mileage, acceleration, seatsNumber, automaticTransmission, airConditioning)
        {

            FuelType = fuelType;
            FuelTankCapacity = fuelTankCapacity;
            FuelEconomy = fuelEconomy;
        }

        public Gasсar(string model, Type type, Manufacturer manufacturer, int price, int maxspeed, int year, int mileage, int seatsNumber, int fuelEconomy, int fuelTankCapacity, string fuelType, bool automaticTransmission)
        {
            Model = model;
            Type = type;
            Manufacturer = manufacturer;
            this.price = price;
            this.MaxSpeed = maxspeed;
            Year = year;
            Mileage = mileage;
            SeatsNumber = seatsNumber;
            FuelEconomy = fuelEconomy;
            FuelTankCapacity = fuelTankCapacity;
            FuelType = fuelType;
            AutomaticTransmission = automaticTransmission;
        }

        public Gasсar(Manufacturer manufacturer, Type type, string model, int price, int year, int mileage, int seatsNumber, bool automaticTransmission, string fuelType, int fuelTankCapacity, int fuelEconomy)
        {
            Manufacturer = manufacturer;
            Type = type;
            Model = model;
            this.price = price;
            Year = year;
            Mileage = mileage;
            SeatsNumber = seatsNumber;
            AutomaticTransmission = automaticTransmission;
            FuelType = fuelType;
            FuelTankCapacity = fuelTankCapacity;
            FuelEconomy = fuelEconomy;
        }

        public override string ToString()
        {
            return "Gas car: " + base.ToString() + $", Fuel Type: {FuelType}, FuelTank Capacity: {FuelTankCapacity}, Fuel Economy: {FuelEconomy} ";
        }
    }
}