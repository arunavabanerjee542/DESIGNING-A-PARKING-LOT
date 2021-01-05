using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot
{
    class Admin : ParkingLotUser
    {


        public Admin(int i, string n)
        {
            id = i;
            name = n;
           
            search = new Search();
        }




        public void AddParkingSpot(Floors f ,ParkingSpot p)
        {
            f.AddParkingSpot(p);
        }

        public void RemoveParkingSpot(ParkingSpot ps,List<ParkingSpot> p)
        {

        }

        public void UpdateParkingSpot(ParkingSpot p)
        {

        }

    }
}
