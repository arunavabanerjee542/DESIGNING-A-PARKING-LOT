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

        public void makePaymenttoAttendent(Attendent attend)
        {
            attend.pay();
        }

        public void getParkingTicket()
        {

        }

    }
}
