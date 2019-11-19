using System;
using System.Collections.Generic;
using System.Text;

using Vehicle.Enums;
using Vehicle.Factories;
using Vehicle.Interfaces; 

namespace Vehicle
{
    public class Vehicle
    {
        private readonly Dictionary<VehcileEnum.Actions, VehicleFactory> _factories;

        public Vehicle()
        {
           _factories = new Dictionary<VehcileEnum.Actions, VehicleFactory>
            {
                { VehcileEnum.Actions.Car, new CarFactory() },
                { VehcileEnum.Actions.Bike, new BikeFactory() },
                { VehcileEnum.Actions.Rickshaw, new RickshawFactory() }
            };
        }

        public IVehicle ExecuteCreation(VehcileEnum.Actions action, int CylinderCapacity, int NumberOfWheels, int NumberOfSeats) => 
            _factories[action].Create(CylinderCapacity, NumberOfWheels, NumberOfSeats); 
    }
}
