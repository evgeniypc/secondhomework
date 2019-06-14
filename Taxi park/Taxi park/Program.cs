using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{
    class Program
    {
        static void Main(string[] args)
        {
           
               
                List<Car> taxipool = new List<Car>
            {
                new Gascar(Manufacturer.Audi, Type.Coupe, "T9", 50000, 2017, 155, 0, 5.3f, 2, true, true, "gasoline", 50, 26),
                new ElectricCar(Manufacturer.Tesla, Type.Coupe, "Model S", 85000, 2016, 241, 405, 2.5f, 5, true, true, "Lithium ion", 570, 220),
                new Gascar(Manufacturer.Mitsubishi, Type.Hatchback, "Colt", 10000, 2014, 120, 50, 6.3f, 5, true, true, "gasoline", 50, 20),
                new ElectricCar(Manufacturer.Nissan, Type.Hatchback, "Leaf", 15000, 2016, 241, 405, 2.5f, 5, true, true, "Lithium ion", 400, 180),
            };

                Console.WriteLine("Calculating total taxi pool cost ");
                long carsCost = Taxipark.CalculateCarsCost(taxipool);
                Console.WriteLine($"Taxipark total cost is ${carsCost}");

                Console.WriteLine();
                Console.WriteLine("Searching cars by speed");
                List<Car> carsBySpeed = Taxipark.SearchBySpeed(taxipool, 150, 160);

                if (carsBySpeed.Count == 0)
                {
                    Console.WriteLine("There are no cars with defined maximum speed");
                }
                else
                {
                    foreach (Car car in carsBySpeed)
                    {
                        Console.WriteLine(car);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Sorting cars by fuel economy");
                List<Car> sortedListByFuelEconomy = Taxipark.SortByFuelEconomy(taxipool);
                foreach (var car in sortedListByFuelEconomy)
                {
                    Console.WriteLine(car);
                }

                Console.WriteLine();
                Console.WriteLine("Using interface implementation");
                Bus bus = new Bus(Manufacturer.MercedesBenz, Type.Van, "Sprinter", 20000, 2012, 120, 100, 2.3f, 2, true, true, "gasoline", 50, 26);
                bus.AddPassenger();
                Console.WriteLine(bus.GetPassengerCount());

            }
        }
    }