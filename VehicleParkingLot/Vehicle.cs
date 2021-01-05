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


        public Vehicle(int vn, VehicleType vt, DateTime en, DateTime ex)
        {
            vehiclenumber = vn;
            vehicletype = vt;
            entrytime = en;
            exittime = ex;


        }




        public int DurationInMinutes()
        {
            return 0;  // entrytime - exittime 
        }
        

    }
}