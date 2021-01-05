using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot
{
    public class ParkingLot
    {

        public Address address;
        public List<Floors> floors;
        public List<Gate> gates;


        public ParkingLot()
        {
            address = new Address();
            floors = new List<Floors>();
            gates = new List<Gate>();
        }



    }
}
