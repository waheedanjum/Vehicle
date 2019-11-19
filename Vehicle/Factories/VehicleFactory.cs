using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Interfaces;

namespace Vehicle.Factories
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle Create(int CylinderCapacity, int NumberOfWheels, int NumberOfSeats);
    }
}
