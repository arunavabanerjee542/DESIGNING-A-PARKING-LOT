using System;

namespace VehicleParkingLot
{
    public enum VehicleType
    {
        car, bus, truck, bike
    }

    public class Vehicle
    {
        public int vehiclenumber;
        
        public VehicleType vehicletype;

        public DateTime entrytime;

        public DateTime exittime;

        public int DurationInMinutes()
        {
            return 0;  // entrytime - exittime 
        }
        

    }
}