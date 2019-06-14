using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_park
{
    internal class ElectricCar: Car
    {
        public String BatteryType { set; get; }
        public int ChargingTime { set; get; }
        public long LifetimeBattery { set; get; }

        public ElectricCar(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration, int seatsNumber, bool automaticTransmission, bool airConditioning, string batteryType, long lifetimeBattery)
            : base(manufacturer, type, model, price, year, maxSpeed, mileage, acceleration, seatsNumber, automaticTransmission, airConditioning)
        {
            BatteryType = batteryType;
            ChargingTime = chargingTime;
            LifetimeBattery = lifetimeBattery;
        }

        public ElectricCar(Manufacturer manufacturer, Type type, string model, int price, int year, int maxSpeed, int mileage, float acceleration, int seatsNumber, bool automaticTransmission) : base(manufacturer, type, model, price, year, maxSpeed, mileage, acceleration, seatsNumber, automaticTransmission)
        {
        }

        public override string ToString()
        {
            return "Electric car: " + base.ToString() + $", Battery Type: {BatteryType}, Charging Time: {ChargingTime}, Lifetime Battery: {LifetimeBattery} ";
        }

        public override bool Equals(object obj)
        {
            return obj is ElectricCar car &&
                   BatteryType == car.BatteryType &&
                   ChargingTime == car.ChargingTime &&
                   LifetimeBattery == car.LifetimeBattery;
        }
    }
}
