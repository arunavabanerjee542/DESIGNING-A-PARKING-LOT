using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot
{
   public class Attendent : ParkingLotUser
    {
        public Payment p;
      
        public void ProcessTicket()
        {

        }

        public void MakePayment()
        {
            p.pay();
        }


    }
}
