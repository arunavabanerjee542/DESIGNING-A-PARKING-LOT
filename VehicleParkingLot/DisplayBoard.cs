using System.Collections.Generic;
using System.Linq;

namespace VehicleParkingLot
{
    public class DisplayBoard
    {

        public void show(List<ParkingSpot> ps)
        {
            var x = ps.Where(y =>(int)y.ps == 1 ).GroupBy(z => z.vehicle.vehicletype);
        
              foreach(var c in x)
                {
                System.Console.WriteLine(c.Key + " " +c.Count());
                 }

        }

    }
}