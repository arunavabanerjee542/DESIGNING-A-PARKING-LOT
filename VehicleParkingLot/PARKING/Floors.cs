using System.Collections.Generic;

namespace VehicleParkingLot
{
    public class Floors
    {
        public int floor_no;

        public List<ParkingSpot> parkingspot;

        public DisplayBoard db;


       
       

        public Floors(int l)
        {
            parkingspot = new List<ParkingSpot>();
            db = new DisplayBoard();
            floor_no = l;
        }

        public void ShowAvalableSpaces()
        {
           // db.show(parkingspot);
        }

        public void AddParkingSpot(ParkingSpot p)
        {

            parkingspot.Add(p);
        }
           

      


    }

   
}