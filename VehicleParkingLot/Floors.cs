using System.Collections.Generic;

namespace VehicleParkingLot
{
    public class Floors
    {
        public int floor_no;

        public List<ParkingSpot> parkingspot;

        public DisplayBoard db;


        public Floors()
        {
            parkingspot = new List<ParkingSpot>();
            db = new DisplayBoard();
        }

        public void ShowAvalableSpaces()
        {
            db.show(parkingspot);
        }
           

      


    }

   
}