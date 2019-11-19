using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data;
using Vehicle.Interfaces;

namespace Vehicle.Factories
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle Create(int CylinderCapacity, int NumberOfWheels, int NumberOfSeats) =>
            new Car(CylinderCapacity, NumberOfWheels, NumberOfSeats);
    }
}
