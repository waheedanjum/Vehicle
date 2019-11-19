using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Enums
{
    public static class VehcileEnum
    {
        public enum Data
        {
            MaxRoadSpeed = 70,
            MinCylinderCapacity = 50,
            SportsCylinderCapacity = 1400,
            MinCarSeats = 2,
            RickshawWheels = 3,
            FamilyCarSeats = 4,
        }
        
        public enum Actions
        {
            Car,
            Rickshaw,
            Bike
        }

        public static string Rickshaw = "Rickshaw";
        public static string Car = "Car";
        public static string Bike = "MotorBike";
    }
}
