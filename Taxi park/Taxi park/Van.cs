using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{

    class Van : Gasсar, IPassenger
    {
        private int passengers = 0;
        private int cargoId = 0;
        private double cargoWeight = 0;
        private readonly int passengersNumber;

        public Van(String model, Type type, Manufacturer manufacturer, int price, int maxspeed, int year, int mileage, int seatsNumber,
               int fuelEconomy, int fuelTankCapacity, string fuelType, bool automaticTransmission)
               :base( model,
                      type,
                      manufacturer,
                      price,
                      maxspeed,
                      year,
                      mileage,
                      seatsNumber,
                      fuelEconomy,
                      fuelTankCapacity,
                      fuelType,
                      automaticTransmission)
        {
        }

        public Van(String model, Type type, Manufacturer manufacturer, int price, int maxspeed, int year, int mileage, int seatsNumber,
               int fuelEconomy, int fuelTankCapacity, string fuelType, bool automaticTransmission, int cargoId, double cargoWeight)
        : base(
              manufacturer,
              type,
              model,
              price,
              year,
              mileage,
              seatsNumber,
              automaticTransmission,
              fuelType,
              fuelTankCapacity,
              fuelEconomy)
        {
            passengers = passengersNumber;
            this.cargoId = cargoId;
            this.cargoWeight = cargoWeight;
        }


        public int AddPassenger()
        {
            passengers = passengers++;
            return passengers;
        }

        public int GetPassengerCount()
        {
            return passengers;
        }

        public int GetCargoId()
        {
            if (cargoId == 0)
            {
                Console.WriteLine("No cargo assigned yet for the car");
            }
            return cargoId;
        }

        public double GetCargoWeight()
        {
            if (cargoWeight == 0)
            {
                Console.WriteLine("No cargo assigned yet for the car");
            }
            return cargoWeight;
        }


    }
    }