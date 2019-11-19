using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Interfaces;
using Vehicle.Data;

namespace Vehicle.Factories
{
    public class RickshawFactory : VehicleFactory
    {
        public override IVehicle Create(int CylinderCapacity, int NumberOfWheels, int NumberOfSeats) =>
            new Rickshaw(CylinderCapacity, NumberOfWheels, NumberOfSeats);
        
    }
}
