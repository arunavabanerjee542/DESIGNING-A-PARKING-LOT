namespace VehicleParkingLot
{
    public class Gate
    {
       public  int gateid;
        public int floorno;
        public Attendent attend;

    }


    public class EnterGate: Gate
    {
        public void ProcessTicket()
        {
            attend.ProcessTicket();
        }

    }


    public class ExitGate : Gate
    {
        public void ProcessPayment()
        {
            attend.MakePayment();
        }

    }



}