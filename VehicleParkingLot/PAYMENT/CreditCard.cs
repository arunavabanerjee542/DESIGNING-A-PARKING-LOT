using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot.PAYMENT
{
    class CreditCard : IPaymentGateway
    {
        public void pay()
        {
            Console.WriteLine(" PAID VIA CREDIT CARD ");
        }

   
    }
}
