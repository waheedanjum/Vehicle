using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Interfaces;
using Vehicle.Enums;

namespace Vehicle.Data
{
    public class Car : IVehicle
    {
        private readonly int _CylinderCapacity;
        private readonly int _NumberOfWheels;
        private readonly int _NumberOfSeats;
                
        public Car(int CylinderCapacity, int NumberOfWheels, int NumberOfSeats)
        {
            _NumberOfWheels = NumberOfWheels;
            _CylinderCapacity = CylinderCapacity;
            _NumberOfSeats = NumberOfSeats;
        }

        public bool ExtraUrban()
        {
           return _CylinderCapacity >= (int)VehcileEnum.Data.MinCylinderCapacity ? true : false;
        }

        public int MaxRoadSpeed()
        {
            return (int)VehcileEnum.Data.MaxRoadSpeed;
        }
                
        public int CylinderCapacity()
        {
            return _CylinderCapacity;
        }

        public bool Sporty()
        {
            return (_NumberOfSeats >= (int)VehcileEnum.Data.MinCarSeats && _CylinderCapacity >= (int)VehcileEnum.Data.SportsCylinderCapacity) ? true : false;
        }

        public int NumberOfWheels()
        {
            return _NumberOfWheels;
        }

        public string Type()
        {
            return VehcileEnum.Car;
        }

        public bool FamilyVehicle()
        {
            return (_NumberOfWheels > (int)VehcileEnum.Data.RickshawWheels && _NumberOfSeats >= (int)VehcileEnum.Data.FamilyCarSeats) ? true : false;
        }

        public int NumberOfSeats()
        {
            return _NumberOfSeats;
        }
    }
}
