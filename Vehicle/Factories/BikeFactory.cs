using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data;
using Vehicle.Interfaces;

namespace Vehicle.Factories
{
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle Create(int CylinderCapacity, int NumberOfWheels, int NumberOfSeats) =>
          new Bike(CylinderCapacity, NumberOfWheels, NumberOfSeats);
    }
}
