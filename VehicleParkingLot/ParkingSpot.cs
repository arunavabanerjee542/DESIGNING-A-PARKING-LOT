namespace VehicleParkingLot
{
    

    public enum ParkingSpotStatus
        {
          available,not_available,under_service
        }


    public class ParkingSpot
    {
        public int spotid ;
       
        public ParkingSpotStatus ps;
        public Vehicle vehicle;


    }
}