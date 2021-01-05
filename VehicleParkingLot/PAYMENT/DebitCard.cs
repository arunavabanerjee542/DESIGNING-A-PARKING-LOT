using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot.PAYMENT
{
    class DebitCard : IPaymentGateway
    {
        public void pay()
        {
            Console.WriteLine(" PAID VIA DEBIT CARD ");
        }
    }
}
