using System;
using Vehicle.Enums;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //initial bike data
            int NumberOfWheels = 0;
            int CylinderCapacity = 0;
            int NoOfSeats = 0;

            foreach(VehcileEnum.Actions action in Enum.GetValues(typeof(VehcileEnum.Actions))) 
            {
               if(action == VehcileEnum.Actions.Car)
               {
                    NumberOfWheels = 4;
                    CylinderCapacity = 1500;
                    NoOfSeats = 5;
               }
               else if(action == VehcileEnum.Actions.Rickshaw) 
               {
                    NumberOfWheels = 3;
                    CylinderCapacity = 70;
                    NoOfSeats = 4;
               } 
               else
               {
                    NumberOfWheels = 2;
                    CylinderCapacity = 45;
                    NoOfSeats = 2;
               }

                var factory = new Vehicle().ExecuteCreation(action, CylinderCapacity, NumberOfWheels, NoOfSeats);
                
                Console.WriteLine("Vechile Type: \t\t " + factory.Type()); ;
                Console.WriteLine("-----------------------------------------");
                
                Console.WriteLine("Cylinder Capacity  \t" + factory.CylinderCapacity());
                Console.WriteLine("Max Motorway Speed \t" + factory.MaxRoadSpeed());
                Console.WriteLine("Family Car \t\t" + factory.FamilyVehicle());
                Console.WriteLine("Motorway Allowed \t " + factory.ExtraUrban());
                Console.WriteLine("Number of Seats \t" + factory.NumberOfSeats());
                Console.WriteLine("Number of Wheels \t" + factory.NumberOfWheels());
                Console.WriteLine("Sports Vehicle \t\t" + factory.Sporty());

                Console.WriteLine("-----------------------------------------");
            }

        }
    }
}
