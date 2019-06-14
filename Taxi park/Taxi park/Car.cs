using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{
    class Car
    {
        public Manufacturer Manufacturer { set; get; }
        public Type Type { set; get; }
        public String Model { set; get; }

        public int Price { set; get; }
        public int Year { set; get; }
        public int Mileage { set; get; }

        public int MaxSpeed { set; get; }
        public float Acceleration { set; get; }

        public int SeatsNumber { set; get; }

        public bool AutomaticTransmission { set; get; }



        public Car(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration, int seatsNumber, bool automaticTransmission)
        {
            Manufacturer = manufacturer;
            Type = type;
            Model = model;
            Price = price;
            Year = year;
            Mileage = mileage;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            SeatsNumber = seatsNumber;
            AutomaticTransmission = automaticTransmission;
          
        }

        public Car(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration, int seatsNumber, bool automaticTransmission, bool airConditioning) : this(manufacturer, type, model, price, year, maxSpeed, mileage, acceleration, seatsNumber, automaticTransmission)
        {
        }

        public override string ToString()
        {
            String carInfo = $"Manufacturer: {Manufacturer}, Type: {Type}, Model: {Model}, Price: {Price}, Year: {Year}, MaxSpeed: {MaxSpeed}, Mileage: {Mileage}," +
                 $" Acceleration: {Acceleration}, Seats Number: {SeatsNumber}";
            if (AutomaticTransmission == true)
            {
                carInfo = carInfo + ", Automatic transmission";
            }
            else { carInfo = carInfo + ", Manual transmission"; }

         
      
    }
}
}
