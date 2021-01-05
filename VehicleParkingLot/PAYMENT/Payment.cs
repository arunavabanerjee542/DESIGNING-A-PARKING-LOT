using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot.PAYMENT
{
    class Payment
    {
        IPaymentGateway paygate;

        public Payment(IPaymentGateway ip)
        {

            paygate = ip;

        }


        public void MakePayment()
        {
            paygate.pay();
        }



    }
}
