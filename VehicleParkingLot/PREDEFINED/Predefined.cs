using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkingLot.PREDEFINED
{
    class Predefined
    {

        public Customer InitializeCustomers()
        {
            Vehicle v1 = new Vehicle(1124, VehicleType.car, DateTime.Now, DateTime.Now);
            Customer user = new Customer(1, " Ram ", v1);
     /*
            Vehicle v2 = new Vehicle(1124, VehicleType.car, DateTime.Now, DateTime.Now);
            Customer user2 = new Customer(2, " Raj ", v2);

            Vehicle v3 = new Vehicle(1124, VehicleType.car, DateTime.Now, DateTime.Now);
            Customer user3 = new Customer(3, " Rama ", v3);


            Vehicle v4 = new Vehicle(1124, VehicleType.car, DateTime.Now, DateTime.Now);
            Customer user4 = new Customer(4, " Rajev ", v4);

            List<Customer> c = new List<Customer>();
            c.Add(user);
            c.Add(user2);
            c.Add(user3);
            c.Add(user4);
            */

            return user;

        }


        public Admin InitializeAdmin()
        {

            return new Admin(2, "Adam");

        }


        public List<ParkingSpot> IniatializeParkingSpot()
        {
            List<ParkingSpot> l = new List<ParkingSpot>() {

             new ParkingSpot(1, ParkingSpotStatus.available, VehicleType.car),

             new ParkingSpot(2, ParkingSpotStatus.available, VehicleType.bike),
             new ParkingSpot(3, ParkingSpotStatus.available, VehicleType.truck),
             new ParkingSpot(4, ParkingSpotStatus.available, VehicleType.car),
        };

            return l;

        }



        public Floors IniatializeFloors()
        {
            return new Floors(1);
        }






    }
}
