using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{
    class Taxipark
    {

        public static long CalculateCarsCost(List<Car> cars)
        {
            long sum = 0;
            foreach (Car car in cars)
            {
                sum += car.price;
            }
            return sum;
        }

        public static List<Car> SearchBySpeed(List<Car> cars, int min, int max)
        {
            List<Car> carSelection = new List<Car>();

            foreach (Car car in cars)
            {
                if (car.MaxSpeed >= min && car.MaxSpeed <= max)
                {
                    carSelection.Add(car);
                }
            }

            return carSelection;
        }

        public static List<Car> SortByFuelEconomy(List<Car> cars)
        {
            List<Gasсar> gasCars = new List<Gasсar>();
            List<ElectricCar> electricCars = new List<ElectricCar>();

            if (cars.Count == 0)
            {
                Console.WriteLine("Nothing to sort");
            }

            foreach (Car car in cars)
            {
                if (car is ElectricCar)
                {
                    electricCars.Add(car as ElectricCar);
                }
                else if (car is GasCar)
                {
                    gasCars.Add(car as Gasсar);
                }
            }

            gasCars.Sort((car1, car2) => car1.FuelEconomy.CompareTo(car2.FuelEconomy));
            electricCars.Sort((car1, car2) => car1.LifetimeBattery.CompareTo(car2.LifetimeBattery));

            List<Car> result = new List<Car>();
            result.AddRange(gasCars);
            result.AddRange(electricCars);

            return result;
        }

        private class GasCar
        {
        }
    }

    internal class ElectricCar
    {
        private int v;

        public ElectricCar(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration, int seatsNumber, bool automaticTransmission, bool airConditioning, string batteryType, long lifetimeBattery, int v) : this(manufacturer, type, model, price, year, maxSpeed, mileage, acceleration, seatsNumber, automaticTransmission, airConditioning, batteryType, lifetimeBattery)
        {
            this.v = v;
        }
    }

    public class Car
    {
        internal long Price;
        internal int MaxSpeed;

        public Car(Manufacturer manufacturer, Type type)
        {
        }

        public long price { get; internal set; }
    }
}
