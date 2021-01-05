using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot
{
    class Customer : ParkingLotUser
    {
        

        public Vehicle v;

        public Customer(int i, string n, Vehicle vehicle)
        {
            id = i;
            name = n;
            v = vehicle;
            search = new Search();
        }


        public void makePaymenttoAttendent(Attendent attend)
        {
           // attend.pay();
        }

        public void getParkingTicket()
        {

        }



    }
}
