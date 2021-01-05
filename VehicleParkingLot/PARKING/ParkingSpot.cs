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
        public VehicleType vt;

        public ParkingSpot(int spot, ParkingSpotStatus pss, VehicleType v)
        {
            spotid = spot;
            ps = pss;
            vt = v;

        }


    }
}