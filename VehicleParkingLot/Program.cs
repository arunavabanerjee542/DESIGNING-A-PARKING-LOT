using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleParkingLot.PREDEFINED;

namespace VehicleParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

            Predefined p = new Predefined();

            ParkingLot park = new ParkingLot();
            Floors fl = p.IniatializeFloors();
            park.floors.Add(fl);


            Customer cust;
            Admin admin;
          

            while (1 == 1)
            {
                Console.WriteLine(" ADMIN PRESS 1 ");
                Console.WriteLine(" CUSTOMER PRESS 2 ");

                int choice = Convert.ToInt32(Console.ReadLine());

            //Create a few Vehicle and User Class

           
                if (choice == 2)
                {
                    cust = p.InitializeCustomers();
                    cust.search.ShowParkingSpaceByVehicleType(cust.v, park);

                }
                else
                {
                    admin = p.InitializeAdmin();

                    foreach (var x in p.IniatializeParkingSpot())
                    {

                        admin.AddParkingSpot(park.floors[0],x);
                    }

                }

            }

          



        }
    }
}
