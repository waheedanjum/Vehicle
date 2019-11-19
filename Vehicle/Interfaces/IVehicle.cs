using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Interfaces
{
    public interface IVehicle
    {
        string Type();

        int NumberOfWheels();

        int NumberOfSeats();

        int MaxRoadSpeed();
               
        int CylinderCapacity();

        Boolean Sporty();

        Boolean ExtraUrban();

        Boolean FamilyVehicle();

    }
}
